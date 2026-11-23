using System;

namespace FoodExpress.Models
{
    public class OrderStatusHistory
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string OldStatus { get; set; } = string.Empty;
        public string NewStatus { get; set; } = string.Empty;
        public DateTime ChangedAt { get; set; } = DateTime.Now;
        public string ChangedBy { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
