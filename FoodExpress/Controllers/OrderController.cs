using System;
using System.Collections.Generic;
using System.Linq;
using FoodExpress.Data.Repositories;
using FoodExpress.Models;

namespace FoodExpress.Controllers
{
    public class OrderController
    {
        private readonly OrderRepository _orderRepo = new OrderRepository();
        private readonly MenuItemRepository _menuRepo = new MenuItemRepository();
        private readonly CartController _cartController = new CartController();

        // FR-4.1 to FR-4.8: Checkout & Order Placement
        public (bool Success, string Message, Order? Order) Checkout(string deliveryAddress, string contactPhone, string paymentMethod)
        {
            var user = AuthController.CurrentUser;
            if (user == null)
            {
                return (false, "Please log in before placing an order.", null);
            }

            var cartItems = _cartController.GetCartItems();

            // FR-4.1: Must contain at least one item
            if (cartItems.Count == 0)
            {
                return (false, "Your cart is empty. Please add items to your cart before checkout.", null);
            }

            // FR-4.2: Delivery address and contact phone required
            if (string.IsNullOrWhiteSpace(deliveryAddress))
            {
                return (false, "Please provide a valid delivery address.", null);
            }

            if (string.IsNullOrWhiteSpace(contactPhone))
            {
                return (false, "Please provide a contact phone number.", null);
            }

            if (string.IsNullOrWhiteSpace(paymentMethod))
            {
                paymentMethod = "Cash on Delivery";
            }

            // Alternative flows (UC-1): verify that items in cart are still available
            foreach (var cartItem in cartItems)
            {
                var currentMenuItem = _menuRepo.GetById(cartItem.MenuItemId);
                if (currentMenuItem == null || !currentMenuItem.IsActive || !currentMenuItem.IsAvailable)
                {
                    return (false, $"'{cartItem.Name}' is no longer available. Please remove it from your cart before proceeding.", null);
                }
            }

            var order = new Order
            {
                UserId = user.Id,
                CustomerName = user.FullName,
                CustomerPhone = user.PhoneNumber,
                DeliveryAddress = deliveryAddress.Trim(),
                ContactPhone = contactPhone.Trim(),
                PaymentMethod = paymentMethod,
                OrderDate = DateTime.Now
            };

            // Copy snapshot prices (FR-4.5)
            var orderItems = cartItems.Select(ci => new OrderItem
            {
                MenuItemId = ci.MenuItemId,
                MenuItemName = ci.Name,
                UnitPrice = ci.Price,
                Quantity = ci.Quantity
            }).ToList();

            // Transactional save (FR-4.7)
            var result = _orderRepo.CreateOrderTransactional(order, orderItems);

            if (result.Success)
            {
                // FR-4.6: Clear cart after successful placement
                _cartController.ClearCart();
            }

            return result;
        }

        public List<Order> GetCustomerOrders(int customerId)
        {
            return _orderRepo.GetOrdersByCustomer(customerId);
        }

        public Order? GetOrderDetails(int orderId)
        {
            return _orderRepo.GetOrderById(orderId);
        }

        // FR-5.5 & BR-7: Customer cancel order only if Placed
        public (bool Success, string Message) CustomerCancelOrder(int orderId)
        {
            var user = AuthController.CurrentUser;
            string changedBy = user?.FullName ?? "Customer";
            return _orderRepo.CancelOrder(orderId, isAdmin: false, changedBy: changedBy, reason: "Cancelled by customer");
        }

        // Admin operations
        public List<Order> AdminGetAllOrders(string? statusFilter, DateTime? dateFilter)
        {
            return _orderRepo.GetAllOrders(statusFilter, dateFilter);
        }

        // FR-7.3, FR-7.4 & BR-6: Placed -> Preparing -> Out for Delivery -> Delivered
        public (bool Success, string Message) AdminAdvanceOrderStatus(int orderId, string currentStatus)
        {
            var user = AuthController.CurrentUser;
            string changedBy = user?.FullName ?? "Staff/Admin";

            string nextStatus = OrderRepository.GetNextAllowedStatus(currentStatus);
            if (string.IsNullOrEmpty(nextStatus))
            {
                return (false, $"Order has already reached final stage: {currentStatus}");
            }

            return _orderRepo.UpdateOrderStatus(orderId, currentStatus, nextStatus, changedBy);
        }

        // FR-7.5: Admin cancel order before delivered
        public (bool Success, string Message) AdminCancelOrder(int orderId, string reason)
        {
            var user = AuthController.CurrentUser;
            string changedBy = user?.FullName ?? "Admin";
            return _orderRepo.CancelOrder(orderId, isAdmin: true, changedBy: changedBy, reason: reason);
        }

        public List<OrderStatusHistory> GetOrderStatusHistory(int orderId)
        {
            return _orderRepo.GetStatusHistory(orderId);
        }
    }
}
