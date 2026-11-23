using System;
using System.Collections.Generic;
using FoodExpress.Models;
using Microsoft.Data.Sqlite;

namespace FoodExpress.Data.Repositories
{
    public class OrderRepository
    {
        // FR-4.5 & FR-4.7: Transactional order creation
        public (bool Success, string Message, Order? Order) CreateOrderTransactional(Order order, List<OrderItem> items)
        {
            if (items == null || items.Count == 0)
                return (false, "Order must contain at least one item.", null);

            using var conn = DatabaseHelper.GetConnection();
            using var transaction = conn.BeginTransaction();

            try
            {
                // Generate a unique order number (e.g. ORD-YYYYMMDD-XXXX)
                string datePrefix = DateTime.Now.ToString("yyyyMMdd");
                long countToday = 0;
                using (var countCmd = conn.CreateCommand())
                {
                    countCmd.Transaction = transaction;
                    countCmd.CommandText = "SELECT COUNT(*) FROM Orders WHERE OrderNumber LIKE @prefix;";
                    countCmd.Parameters.AddWithValue("@prefix", $"ORD-{datePrefix}-%");
                    countToday = (long)(countCmd.ExecuteScalar() ?? 0L);
                }

                string orderNumber = $"ORD-{datePrefix}-{(countToday + 1):D4}";
                order.OrderNumber = orderNumber;
                order.Status = "Placed";
                order.OrderDate = DateTime.Now;

                // Calculate total
                decimal total = 0m;
                foreach (var item in items)
                {
                    total += item.UnitPrice * item.Quantity;
                }
                order.TotalAmount = total;

                // Insert Order
                using (var orderCmd = conn.CreateCommand())
                {
                    orderCmd.Transaction = transaction;
                    orderCmd.CommandText = @"
                        INSERT INTO Orders (OrderNumber, UserId, DeliveryAddress, ContactPhone, PaymentMethod, Status, TotalAmount, OrderDate)
                        VALUES (@num, @userId, @addr, @phone, @pay, @status, @total, @date);
                        SELECT last_insert_rowid();";

                    orderCmd.Parameters.AddWithValue("@num", order.OrderNumber);
                    orderCmd.Parameters.AddWithValue("@userId", order.UserId);
                    orderCmd.Parameters.AddWithValue("@addr", order.DeliveryAddress.Trim());
                    orderCmd.Parameters.AddWithValue("@phone", order.ContactPhone.Trim());
                    orderCmd.Parameters.AddWithValue("@pay", order.PaymentMethod);
                    orderCmd.Parameters.AddWithValue("@status", order.Status);
                    orderCmd.Parameters.AddWithValue("@total", (double)order.TotalAmount);
                    orderCmd.Parameters.AddWithValue("@date", order.OrderDate.ToString("yyyy-MM-dd HH:mm:ss"));

                    long orderId = (long)(orderCmd.ExecuteScalar() ?? 0L);
                    order.Id = (int)orderId;
                }

                // Insert Order Items (copying unit price snapshot, FR-4.5)
                foreach (var item in items)
                {
                    using var itemCmd = conn.CreateCommand();
                    itemCmd.Transaction = transaction;
                    itemCmd.CommandText = @"
                        INSERT INTO OrderItems (OrderId, MenuItemId, MenuItemName, UnitPrice, Quantity)
                        VALUES (@orderId, @menuId, @name, @price, @qty);";

                    itemCmd.Parameters.AddWithValue("@orderId", order.Id);
                    itemCmd.Parameters.AddWithValue("@menuId", item.MenuItemId);
                    itemCmd.Parameters.AddWithValue("@name", item.MenuItemName);
                    itemCmd.Parameters.AddWithValue("@price", (double)item.UnitPrice);
                    itemCmd.Parameters.AddWithValue("@qty", item.Quantity);
                    itemCmd.ExecuteNonQuery();

                    item.OrderId = order.Id;
                }

                // Insert initial status history (FR-7.7)
                using (var historyCmd = conn.CreateCommand())
                {
                    historyCmd.Transaction = transaction;
                    historyCmd.CommandText = @"
                        INSERT INTO OrderStatusHistory (OrderId, OldStatus, NewStatus, ChangedAt, ChangedBy, Notes)
                        VALUES (@orderId, '', 'Placed', @changedAt, @by, 'Order successfully placed by customer');";

                    historyCmd.Parameters.AddWithValue("@orderId", order.Id);
                    historyCmd.Parameters.AddWithValue("@changedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    historyCmd.Parameters.AddWithValue("@by", string.IsNullOrEmpty(order.CustomerName) ? "Customer" : order.CustomerName);
                    historyCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                order.Items = items;
                return (true, "Order placed successfully!", order);
            }
            catch (Exception ex)
            {
                try { transaction.Rollback(); } catch { }
                return (false, $"Failed to save order: {ex.Message}", null);
            }
        }

        public List<Order> GetAllOrders(string? statusFilter = null, DateTime? dateFilter = null)
        {
            var list = new List<Order>();
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();

            string sql = @"
                SELECT o.Id, o.OrderNumber, o.UserId, u.FullName AS CustomerName, u.PhoneNumber AS CustomerPhone,
                       o.DeliveryAddress, o.ContactPhone, o.PaymentMethod, o.Status, o.TotalAmount, o.OrderDate
                FROM Orders o
                LEFT JOIN Users u ON o.UserId = u.Id
                WHERE 1=1 ";

            if (!string.IsNullOrWhiteSpace(statusFilter) && statusFilter != "All")
            {
                sql += " AND o.Status = @status ";
                cmd.Parameters.AddWithValue("@status", statusFilter);
            }

            if (dateFilter.HasValue)
            {
                string dateStr = dateFilter.Value.ToString("yyyy-MM-dd");
                sql += " AND date(o.OrderDate) = date(@orderDate) ";
                cmd.Parameters.AddWithValue("@orderDate", dateStr);
            }

            // FR-7.1: newest first
            sql += " ORDER BY o.Id DESC;";
            cmd.CommandText = sql;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(MapOrderSummary(reader));
            }
            return list;
        }

        public List<Order> GetOrdersByCustomer(int customerId)
        {
            var list = new List<Order>();
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT o.Id, o.OrderNumber, o.UserId, u.FullName AS CustomerName, u.PhoneNumber AS CustomerPhone,
                       o.DeliveryAddress, o.ContactPhone, o.PaymentMethod, o.Status, o.TotalAmount, o.OrderDate
                FROM Orders o
                LEFT JOIN Users u ON o.UserId = u.Id
                WHERE o.UserId = @userId
                ORDER BY o.Id DESC;";
            cmd.Parameters.AddWithValue("@userId", customerId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(MapOrderSummary(reader));
            }
            return list;
        }

        public Order? GetOrderById(int orderId)
        {
            Order? order = null;
            using var conn = DatabaseHelper.GetConnection();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT o.Id, o.OrderNumber, o.UserId, u.FullName AS CustomerName, u.PhoneNumber AS CustomerPhone,
                           o.DeliveryAddress, o.ContactPhone, o.PaymentMethod, o.Status, o.TotalAmount, o.OrderDate
                    FROM Orders o
                    LEFT JOIN Users u ON o.UserId = u.Id
                    WHERE o.Id = @id;";
                cmd.Parameters.AddWithValue("@id", orderId);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    order = MapOrderSummary(reader);
                }
            }

            if (order != null)
            {
                order.Items = GetOrderItems(order.Id);
                order.StatusHistory = GetStatusHistory(order.Id);
            }

            return order;
        }

        public List<OrderItem> GetOrderItems(int orderId)
        {
            var list = new List<OrderItem>();
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Id, OrderId, MenuItemId, MenuItemName, UnitPrice, Quantity
                FROM OrderItems
                WHERE OrderId = @orderId
                ORDER BY Id ASC;";
            cmd.Parameters.AddWithValue("@orderId", orderId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new OrderItem
                {
                    Id = reader.GetInt32(0),
                    OrderId = reader.GetInt32(1),
                    MenuItemId = reader.GetInt32(2),
                    MenuItemName = reader.GetString(3),
                    UnitPrice = Convert.ToDecimal(reader.GetDouble(4)),
                    Quantity = reader.GetInt32(5)
                });
            }
            return list;
        }

        public List<OrderStatusHistory> GetStatusHistory(int orderId)
        {
            var list = new List<OrderStatusHistory>();
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT Id, OrderId, OldStatus, NewStatus, ChangedAt, ChangedBy, Notes
                FROM OrderStatusHistory
                WHERE OrderId = @orderId
                ORDER BY Id ASC;";
            cmd.Parameters.AddWithValue("@orderId", orderId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new OrderStatusHistory
                {
                    Id = reader.GetInt32(0),
                    OrderId = reader.GetInt32(1),
                    OldStatus = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    NewStatus = reader.GetString(3),
                    ChangedAt = reader.IsDBNull(4) ? DateTime.Now : DateTime.Parse(reader.GetString(4)),
                    ChangedBy = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    Notes = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
                });
            }
            return list;
        }

        // FR-7.3, FR-7.4 & BR-6: Placed -> Preparing -> Out for Delivery -> Delivered
        public (bool Success, string Message) UpdateOrderStatus(int orderId, string expectedOldStatus, string newStatus, string changedBy, string notes = "")
        {
            // Verify progression rules
            string nextValidStatus = GetNextAllowedStatus(expectedOldStatus);
            if (!string.Equals(nextValidStatus, newStatus, StringComparison.OrdinalIgnoreCase))
            {
                return (false, $"Invalid status transition from '{expectedOldStatus}' to '{newStatus}'. Expected '{nextValidStatus}'.");
            }

            using var conn = DatabaseHelper.GetConnection();
            using var transaction = conn.BeginTransaction();

            try
            {
                using (var updateCmd = conn.CreateCommand())
                {
                    updateCmd.Transaction = transaction;
                    updateCmd.CommandText = "UPDATE Orders SET Status = @newStatus WHERE Id = @id AND Status = @oldStatus;";
                    updateCmd.Parameters.AddWithValue("@newStatus", newStatus);
                    updateCmd.Parameters.AddWithValue("@id", orderId);
                    updateCmd.Parameters.AddWithValue("@oldStatus", expectedOldStatus);

                    int rows = updateCmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        transaction.Rollback();
                        return (false, "Order status may have been updated by another process. Please refresh.");
                    }
                }

                // Record history (FR-7.7)
                using (var histCmd = conn.CreateCommand())
                {
                    histCmd.Transaction = transaction;
                    histCmd.CommandText = @"
                        INSERT INTO OrderStatusHistory (OrderId, OldStatus, NewStatus, ChangedAt, ChangedBy, Notes)
                        VALUES (@orderId, @oldStatus, @newStatus, @date, @by, @notes);";

                    histCmd.Parameters.AddWithValue("@orderId", orderId);
                    histCmd.Parameters.AddWithValue("@oldStatus", expectedOldStatus);
                    histCmd.Parameters.AddWithValue("@newStatus", newStatus);
                    histCmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    histCmd.Parameters.AddWithValue("@by", changedBy);
                    histCmd.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(notes) ? $"Status advanced to {newStatus}" : notes);
                    histCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return (true, $"Order status changed to '{newStatus}'.");
            }
            catch (Exception ex)
            {
                try { transaction.Rollback(); } catch { }
                return (false, $"Error updating order status: {ex.Message}");
            }
        }

        // FR-5.5 (customer cancel) & FR-7.5 (admin cancel)
        public (bool Success, string Message) CancelOrder(int orderId, bool isAdmin, string changedBy, string reason = "")
        {
            using var conn = DatabaseHelper.GetConnection();
            string currentStatus = "";

            using (var checkCmd = conn.CreateCommand())
            {
                checkCmd.CommandText = "SELECT Status FROM Orders WHERE Id = @id;";
                checkCmd.Parameters.AddWithValue("@id", orderId);
                var obj = checkCmd.ExecuteScalar();
                if (obj == null)
                    return (false, "Order not found.");
                currentStatus = obj.ToString() ?? "";
            }

            if (string.Equals(currentStatus, "Delivered", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(currentStatus, "Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                return (false, $"Cannot cancel order with status '{currentStatus}'.");
            }

            // Customer can ONLY cancel if Placed (FR-5.5, BR-7)
            if (!isAdmin && !string.Equals(currentStatus, "Placed", StringComparison.OrdinalIgnoreCase))
            {
                return (false, "Customers can only cancel orders while the status is 'Placed'.");
            }

            using var transaction = conn.BeginTransaction();
            try
            {
                using (var updateCmd = conn.CreateCommand())
                {
                    updateCmd.Transaction = transaction;
                    updateCmd.CommandText = "UPDATE Orders SET Status = 'Cancelled' WHERE Id = @id;";
                    updateCmd.Parameters.AddWithValue("@id", orderId);
                    updateCmd.ExecuteNonQuery();
                }

                using (var histCmd = conn.CreateCommand())
                {
                    histCmd.Transaction = transaction;
                    histCmd.CommandText = @"
                        INSERT INTO OrderStatusHistory (OrderId, OldStatus, NewStatus, ChangedAt, ChangedBy, Notes)
                        VALUES (@orderId, @oldStatus, 'Cancelled', @date, @by, @notes);";

                    histCmd.Parameters.AddWithValue("@orderId", orderId);
                    histCmd.Parameters.AddWithValue("@oldStatus", currentStatus);
                    histCmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    histCmd.Parameters.AddWithValue("@by", changedBy);
                    histCmd.Parameters.AddWithValue("@notes", string.IsNullOrEmpty(reason) ? "Order cancelled" : reason);
                    histCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                return (true, "Order has been cancelled.");
            }
            catch (Exception ex)
            {
                try { transaction.Rollback(); } catch { }
                return (false, $"Failed to cancel order: {ex.Message}");
            }
        }

        public static string GetNextAllowedStatus(string currentStatus)
        {
            return currentStatus switch
            {
                "Placed" => "Preparing",
                "Preparing" => "Out for Delivery",
                "Out for Delivery" => "Delivered",
                _ => ""
            };
        }

        // FR-8.1 & FR-8.2: Dashboard metrics
        public DashboardMetrics GetDashboardMetrics()
        {
            var metrics = new DashboardMetrics();
            using var conn = DatabaseHelper.GetConnection();

            string todayStr = DateTime.Now.ToString("yyyy-MM-dd");

            // Today's total sales (only from non-cancelled orders)
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT IFNULL(SUM(TotalAmount), 0.0) 
                    FROM Orders 
                    WHERE date(OrderDate) = date(@today) AND Status != 'Cancelled';";
                cmd.Parameters.AddWithValue("@today", todayStr);
                metrics.TodaySales = Convert.ToDecimal(cmd.ExecuteScalar() ?? 0.0);
            }

            // Today's orders count
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Orders WHERE date(OrderDate) = date(@today);";
                cmd.Parameters.AddWithValue("@today", todayStr);
                metrics.TodayOrdersCount = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
            }

            // Counts by status
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT Status, COUNT(*) FROM Orders GROUP BY Status;";
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string status = reader.GetString(0);
                    int count = reader.GetInt32(1);

                    switch (status)
                    {
                        case "Placed": metrics.PlacedCount = count; break;
                        case "Preparing": metrics.PreparingCount = count; break;
                        case "Out for Delivery": metrics.OutForDeliveryCount = count; break;
                        case "Delivered": metrics.DeliveredCount = count; break;
                        case "Cancelled": metrics.CancelledCount = count; break;
                    }
                }
            }

            // Best-selling items (FR-8.2)
            metrics.BestSellers = GetBestSellingItems(5);

            return metrics;
        }

        public List<BestSellerItem> GetBestSellingItems(int topCount = 5)
        {
            var list = new List<BestSellerItem>();
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();

            cmd.CommandText = @"
                SELECT oi.MenuItemName, IFNULL(c.Name, 'General') AS CategoryName,
                       SUM(oi.Quantity) AS TotalQty, 
                       SUM(oi.UnitPrice * oi.Quantity) AS TotalRev
                FROM OrderItems oi
                JOIN Orders o ON oi.OrderId = o.Id
                LEFT JOIN MenuItems m ON oi.MenuItemId = m.Id
                LEFT JOIN Categories c ON m.CategoryId = c.Id
                WHERE o.Status != 'Cancelled'
                GROUP BY oi.MenuItemName
                ORDER BY TotalQty DESC
                LIMIT @top;";
            cmd.Parameters.AddWithValue("@top", topCount);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new BestSellerItem
                {
                    ItemName = reader.GetString(0),
                    CategoryName = reader.IsDBNull(1) ? "General" : reader.GetString(1),
                    QuantitySold = reader.GetInt32(2),
                    TotalRevenue = Convert.ToDecimal(reader.GetDouble(3))
                });
            }
            return list;
        }

        private static Order MapOrderSummary(SqliteDataReader reader)
        {
            return new Order
            {
                Id = reader.GetInt32(0),
                OrderNumber = reader.GetString(1),
                UserId = reader.GetInt32(2),
                CustomerName = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3),
                CustomerPhone = reader.IsDBNull(4) ? "" : reader.GetString(4),
                DeliveryAddress = reader.GetString(5),
                ContactPhone = reader.GetString(6),
                PaymentMethod = reader.GetString(7),
                Status = reader.GetString(8),
                TotalAmount = Convert.ToDecimal(reader.GetDouble(9)),
                OrderDate = reader.IsDBNull(10) ? DateTime.Now : DateTime.Parse(reader.GetString(10))
            };
        }
    }
}
