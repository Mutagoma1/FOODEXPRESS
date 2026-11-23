using System;

namespace FoodExpress.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = "Customer"; // "Customer" or "Admin"
        public string DefaultAddress { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public bool IsAdmin => string.Equals(Role, "Admin", StringComparison.OrdinalIgnoreCase);
    }
}
