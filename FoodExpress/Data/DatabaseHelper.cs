using System;
using System.Drawing;
using System.IO;
using FoodExpress.Common;
using Microsoft.Data.Sqlite;

namespace FoodExpress.Data
{
    public static class DatabaseHelper
    {
        private static readonly string DbFileName = "foodexpress.db";
        private static readonly string DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DbFileName);
        public static string ConnectionString => $"Data Source={DbPath};";

        public static SqliteConnection GetConnection()
        {
            var conn = new SqliteConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        public static void InitializeDatabase()
        {
            using var conn = GetConnection();

            // Enable Foreign Keys
            using (var pragmaCmd = conn.CreateCommand())
            {
                pragmaCmd.CommandText = "PRAGMA foreign_keys = ON;";
                pragmaCmd.ExecuteNonQuery();
            }

            // Create Tables
            string createTablesSql = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FullName TEXT NOT NULL,
                    Email TEXT NOT NULL UNIQUE COLLATE NOCASE,
                    PhoneNumber TEXT NOT NULL,
                    PasswordHash TEXT NOT NULL,
                    Role TEXT NOT NULL DEFAULT 'Customer',
                    DefaultAddress TEXT,
                    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS Categories (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL UNIQUE,
                    Description TEXT
                );

                CREATE TABLE IF NOT EXISTS MenuItems (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Description TEXT,
                    Price REAL NOT NULL,
                    CategoryId INTEGER NOT NULL,
                    ImagePath TEXT,
                    IsAvailable INTEGER NOT NULL DEFAULT 1,
                    IsActive INTEGER NOT NULL DEFAULT 1,
                    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (CategoryId) REFERENCES Categories(Id) ON DELETE RESTRICT
                );

                CREATE TABLE IF NOT EXISTS Orders (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    OrderNumber TEXT NOT NULL UNIQUE,
                    UserId INTEGER NOT NULL,
                    DeliveryAddress TEXT NOT NULL,
                    ContactPhone TEXT NOT NULL,
                    PaymentMethod TEXT NOT NULL,
                    Status TEXT NOT NULL DEFAULT 'Placed',
                    TotalAmount REAL NOT NULL,
                    OrderDate DATETIME DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE RESTRICT
                );

                CREATE TABLE IF NOT EXISTS OrderItems (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    OrderId INTEGER NOT NULL,
                    MenuItemId INTEGER NOT NULL,
                    MenuItemName TEXT NOT NULL,
                    UnitPrice REAL NOT NULL,
                    Quantity INTEGER NOT NULL,
                    FOREIGN KEY (OrderId) REFERENCES Orders(Id) ON DELETE CASCADE,
                    FOREIGN KEY (MenuItemId) REFERENCES MenuItems(Id)
                );

                CREATE TABLE IF NOT EXISTS OrderStatusHistory (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    OrderId INTEGER NOT NULL,
                    OldStatus TEXT,
                    NewStatus TEXT NOT NULL,
                    ChangedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
                    ChangedBy TEXT,
                    Notes TEXT,
                    FOREIGN KEY (OrderId) REFERENCES Orders(Id) ON DELETE CASCADE
                );
            ";

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = createTablesSql;
                cmd.ExecuteNonQuery();
            }

            SeedInitialData(conn);
        }

        private static void SeedInitialData(SqliteConnection conn)
        {
            // 1. Seed Users if table is empty
            long userCount = 0;
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Users;";
                userCount = (long)(cmd.ExecuteScalar() ?? 0L);
            }

            if (userCount == 0)
            {
                // Admin user
                string adminHash = PasswordHelper.HashPassword("Admin123!");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO Users (FullName, Email, PhoneNumber, PasswordHash, Role, DefaultAddress)
                        VALUES (@name, @email, @phone, @hash, 'Admin', @addr);";
                    cmd.Parameters.AddWithValue("@name", "Administrator");
                    cmd.Parameters.AddWithValue("@email", "admin@foodexpress.com");
                    cmd.Parameters.AddWithValue("@phone", "+250788000001");
                    cmd.Parameters.AddWithValue("@hash", adminHash);
                    cmd.Parameters.AddWithValue("@addr", "FoodExpress HQ, Central City");
                    cmd.ExecuteNonQuery();
                }

                // Customer user (Caleb Ndirima Mutagoma)
                string customerHash = PasswordHelper.HashPassword("Password123!");
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO Users (FullName, Email, PhoneNumber, PasswordHash, Role, DefaultAddress)
                        VALUES (@name, @email, @phone, @hash, 'Customer', @addr);";
                    cmd.Parameters.AddWithValue("@name", "Caleb Ndirima Mutagoma");
                    cmd.Parameters.AddWithValue("@email", "caleb@example.com");
                    cmd.Parameters.AddWithValue("@phone", "+250788123456");
                    cmd.Parameters.AddWithValue("@hash", customerHash);
                    cmd.Parameters.AddWithValue("@addr", "AUCA Masoro Campus, Kigali");
                    cmd.ExecuteNonQuery();
                }
            }

            // 2. Seed Categories if empty
            long categoryCount = 0;
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Categories;";
                categoryCount = (long)(cmd.ExecuteScalar() ?? 0L);
            }

            if (categoryCount == 0)
            {
                var categories = new (string Name, string Description)[]
                {
                    ("Burgers & Sandwiches", "Juicy gourmet burgers and toasted artisan sandwiches"),
                    ("Pizzas & Pastas", "Authentic stone-baked pizzas and traditional pasta recipes"),
                    ("Traditional Dishes", "Local specialties, grilled brochettes, and plantains"),
                    ("Beverages & Juices", "Refreshing cold-pressed juices, sodas, and mocktails"),
                    ("Desserts & Bakery", "Handcrafted decadent cakes, pastries, and sweet treats")
                };

                foreach (var (name, desc) in categories)
                {
                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO Categories (Name, Description) VALUES (@name, @desc);";
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.ExecuteNonQuery();
                }
            }

            // 3. Seed Menu Items if empty
            long menuCount = 0;
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM MenuItems;";
                menuCount = (long)(cmd.ExecuteScalar() ?? 0L);
            }

            if (menuCount == 0)
            {
                // Generate images
                string imgBurger1 = ImageHelper.GeneratePlaceholderImage("Classic Cheeseburger", "Burgers", Color.FromArgb(217, 83, 79), "🍔");
                string imgBurger2 = ImageHelper.GeneratePlaceholderImage("Crispy Chicken Club", "Burgers", Color.FromArgb(240, 173, 78), "🥪");
                string imgPizza1 = ImageHelper.GeneratePlaceholderImage("Margherita Pizza", "Pizzas", Color.FromArgb(230, 81, 0), "🍕");
                string imgPizza2 = ImageHelper.GeneratePlaceholderImage("Pepperoni Deluxe", "Pizzas", Color.FromArgb(198, 40, 40), "🍕");
                string imgPasta = ImageHelper.GeneratePlaceholderImage("Alfredo Chicken Pasta", "Pastas", Color.FromArgb(245, 127, 23), "🍝");
                string imgBrochette = ImageHelper.GeneratePlaceholderImage("Goat Brochettes & Fries", "Traditional", Color.FromArgb(109, 76, 65), "🍢");
                string imgTilapia = ImageHelper.GeneratePlaceholderImage("Grilled Lake Tilapia", "Traditional", Color.FromArgb(55, 71, 79), "🐟");
                string imgJuice = ImageHelper.GeneratePlaceholderImage("Passion Fruit Splash", "Drinks", Color.FromArgb(0, 150, 136), "🧃");
                string imgSmoothie = ImageHelper.GeneratePlaceholderImage("Tropical Mango Smoothie", "Drinks", Color.FromArgb(255, 179, 0), "🥤");
                string imgCake = ImageHelper.GeneratePlaceholderImage("Chocolate Lava Cake", "Desserts", Color.FromArgb(78, 52, 46), "🍰");
                string imgCheesecake = ImageHelper.GeneratePlaceholderImage("NY Strawberry Cheesecake", "Desserts", Color.FromArgb(173, 20, 87), "🎂");

                var items = new[]
                {
                    ("Classic Cheeseburger", "100% prime beef patty, cheddar cheese, lettuce, tomato & secret sauce", 6.50m, 1, imgBurger1, 1),
                    ("Crispy Chicken Club", "Golden fried chicken breast with garlic aioli and crispy smoked bacon", 7.00m, 1, imgBurger2, 1),
                    ("Margherita Pizza", "Fresh mozzarella, Italian san marzano tomato sauce, basil, virgin olive oil", 8.50m, 2, imgPizza1, 1),
                    ("Pepperoni Deluxe", "Loaded with premium beef pepperoni, mozzarella, and chili-infused honey", 10.50m, 2, imgPizza2, 1),
                    ("Alfredo Chicken Pasta", "Fettuccine in creamy parmesan garlic alfredo with tender grilled chicken", 9.50m, 2, imgPasta, 1),
                    ("Goat Brochettes & Fries", "Tender Rwandan spiced goat skewers served with golden chips and spicy pili-pili", 8.00m, 3, imgBrochette, 1),
                    ("Grilled Lake Tilapia", "Whole fresh grilled tilapia seasoned with herbs, served with fried plantains", 12.00m, 3, imgTilapia, 1),
                    ("Passion Fruit Splash", "Chilled freshly squeezed organic passion fruit juice with mint leaves", 3.00m, 4, imgJuice, 1),
                    ("Tropical Mango Smoothie", "Rich blend of ripe mangoes, passion puree, and low-fat creamy yogurt", 3.50m, 4, imgSmoothie, 1),
                    ("Chocolate Lava Cake", "Warm molten Belgian chocolate center served with vanilla drizzle", 4.50m, 5, imgCake, 1),
                    ("NY Strawberry Cheesecake", "Velvety smooth baked cream cheese with sweet wild strawberry glaze", 5.00m, 5, imgCheesecake, 1),
                    ("Seasonal Fruit Salad", "Fresh watermelon, pineapple, kiwi, and grapes (Currently Out of Stock)", 4.00m, 5, "", 0)
                };

                foreach (var item in items)
                {
                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = @"
                        INSERT INTO MenuItems (Name, Description, Price, CategoryId, ImagePath, IsAvailable, IsActive)
                        VALUES (@name, @desc, @price, @catId, @img, @avail, 1);";
                    cmd.Parameters.AddWithValue("@name", item.Item1);
                    cmd.Parameters.AddWithValue("@desc", item.Item2);
                    cmd.Parameters.AddWithValue("@price", (double)item.Item3);
                    cmd.Parameters.AddWithValue("@catId", item.Item4);
                    cmd.Parameters.AddWithValue("@img", item.Item5);
                    cmd.Parameters.AddWithValue("@avail", item.Item6);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
