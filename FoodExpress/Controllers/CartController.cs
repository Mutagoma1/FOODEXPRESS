using System;
using System.Collections.Generic;
using System.Linq;
using FoodExpress.Models;

namespace FoodExpress.Controllers
{
    public class CartController
    {
        // Maintains current user's shopping cart
        private static readonly List<CartItem> _cartItems = new List<CartItem>();

        public event Action? CartChanged;

        public List<CartItem> GetCartItems()
        {
            return _cartItems.ToList();
        }

        // FR-3.1, BR-1, BR-3: Add available menu item to cart
        public (bool Success, string Message) AddToCart(MenuItem item, int quantity = 1)
        {
            if (!AuthController.IsLoggedIn)
            {
                return (false, "You must be logged in to add items to the cart.");
            }

            if (!item.IsAvailable)
            {
                return (false, $"'{item.Name}' is currently unavailable.");
            }

            if (quantity <= 0)
            {
                quantity = 1;
            }

            var existing = _cartItems.FirstOrDefault(c => c.MenuItemId == item.Id);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _cartItems.Add(new CartItem
                {
                    MenuItemId = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Quantity = quantity,
                    ImagePath = item.ImagePath
                });
            }

            OnCartChanged();
            return (true, $"{item.Name} added to cart!");
        }

        // FR-3.2 & BR-2: Change quantity
        public void UpdateQuantity(int menuItemId, int newQuantity)
        {
            var item = _cartItems.FirstOrDefault(c => c.MenuItemId == menuItemId);
            if (item != null)
            {
                if (newQuantity <= 0)
                {
                    _cartItems.Remove(item);
                }
                else
                {
                    item.Quantity = newQuantity;
                }
                OnCartChanged();
            }
        }

        // FR-3.3: Remove item
        public void RemoveItem(int menuItemId)
        {
            var item = _cartItems.FirstOrDefault(c => c.MenuItemId == menuItemId);
            if (item != null)
            {
                _cartItems.Remove(item);
                OnCartChanged();
            }
        }

        // FR-3.5: Clear whole cart
        public void ClearCart()
        {
            _cartItems.Clear();
            OnCartChanged();
        }

        // FR-3.4 & BR-4: Line totals & overall total
        public decimal GetTotalAmount()
        {
            return _cartItems.Sum(i => i.Total);
        }

        public int GetTotalItemCount()
        {
            return _cartItems.Sum(i => i.Quantity);
        }

        private void OnCartChanged()
        {
            CartChanged?.Invoke();
        }
    }
}
