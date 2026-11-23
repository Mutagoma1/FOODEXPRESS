using System;
using System.IO;
using System.Text;
using FoodExpress.Data.Repositories;
using FoodExpress.Models;

namespace FoodExpress.Controllers
{
    public class ReportController
    {
        private readonly OrderRepository _orderRepo = new OrderRepository();

        public DashboardMetrics GetDashboardMetrics()
        {
            return _orderRepo.GetDashboardMetrics();
        }

        // FR-8.3: Export the order list to a CSV file
        public (bool Success, string Message) ExportOrdersToCsv(string filePath, string? statusFilter = null, DateTime? dateFilter = null)
        {
            try
            {
                var orders = _orderRepo.GetAllOrders(statusFilter, dateFilter);

                var sb = new StringBuilder();
                // CSV Header
                sb.AppendLine("Order Number,Date,Customer Name,Contact Phone,Delivery Address,Payment Method,Status,Total Amount");

                foreach (var ord in orders)
                {
                    string safeName = EscapeCsv(ord.CustomerName);
                    string safePhone = EscapeCsv(ord.ContactPhone);
                    string safeAddr = EscapeCsv(ord.DeliveryAddress);
                    string safePay = EscapeCsv(ord.PaymentMethod);

                    sb.AppendLine($"{ord.OrderNumber},{ord.OrderDate:yyyy-MM-dd HH:mm:ss},{safeName},{safePhone},{safeAddr},{safePay},{ord.Status},{ord.TotalAmount:F2}");
                }

                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                return (true, $"Successfully exported {orders.Count} orders to {Path.GetFileName(filePath)}!");
            }
            catch (Exception ex)
            {
                return (false, $"Failed to export orders: {ex.Message}");
            }
        }

        private static string EscapeCsv(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "\"\"";

            if (text.Contains(",") || text.Contains("\"") || text.Contains("\n") || text.Contains("\r"))
            {
                return $"\"{text.Replace("\"", "\"\"")}\"";
            }
            return text;
        }
    }
}
