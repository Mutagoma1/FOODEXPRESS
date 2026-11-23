using System;
using System.Collections.Generic;

namespace FoodExpress.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; } = string.Empty;
        public int UserId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public string DeliveryAddress { get; set; } = string.Empty;
        public string ContactPhone { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = "Cash on Delivery";
        public string Status { get; set; } = "Placed"; // Placed -> Preparing -> Out for Delivery -> Delivered | Cancelled
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public List<OrderStatusHistory> StatusHistory { get; set; } = new List<OrderStatusHistory>();

        public bool CanCustomerCancel => string.Equals(Status, "Placed", StringComparison.OrdinalIgnoreCase);
        public bool IsFinished => string.Equals(Status, "Delivered", StringComparison.OrdinalIgnoreCase) ||
                                  string.Equals(Status, "Cancelled", StringComparison.OrdinalIgnoreCase);
    }
}
