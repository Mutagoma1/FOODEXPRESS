using System;

namespace FoodExpress.Models
{
    public class CartItem
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
        public string? ImagePath { get; set; }

        public decimal Total => Price * Quantity;
    }
}
