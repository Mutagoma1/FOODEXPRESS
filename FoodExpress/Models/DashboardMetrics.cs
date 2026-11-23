using System.Collections.Generic;

namespace FoodExpress.Models
{
    public class DashboardMetrics
    {
        public decimal TodaySales { get; set; }
        public int TodayOrdersCount { get; set; }
        public int PlacedCount { get; set; }
        public int PreparingCount { get; set; }
        public int OutForDeliveryCount { get; set; }
        public int DeliveredCount { get; set; }
        public int CancelledCount { get; set; }
        public int TotalCustomersCount { get; set; }
        public int TotalMenuItemsCount { get; set; }

        public List<BestSellerItem> BestSellers { get; set; } = new List<BestSellerItem>();
    }

    public class BestSellerItem
    {
        public string ItemName { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public int QuantitySold { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}
