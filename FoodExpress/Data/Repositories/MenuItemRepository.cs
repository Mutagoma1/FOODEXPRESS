using System;
using System.Collections.Generic;
using FoodExpress.Models;
using Microsoft.Data.Sqlite;

namespace FoodExpress.Data.Repositories
{
    public class MenuItemRepository
    {
        public List<MenuItem> GetAll(bool includeInactive = false)
        {
            var list = new List<MenuItem>();
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();

            string sql = @"
                SELECT m.Id, m.Name, m.Description, m.Price, m.CategoryId, c.Name AS CategoryName, 
                       m.ImagePath, m.IsAvailable, m.IsActive, m.CreatedAt
                FROM MenuItems m
                LEFT JOIN Categories c ON m.CategoryId = c.Id ";

            if (!includeInactive)
            {
                sql += " WHERE m.IsActive = 1 ";
            }

            sql += " ORDER BY c.Name ASC, m.Name ASC;";
            cmd.CommandText = sql;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(MapMenuItem(reader));
            }
            return list;
        }

        public List<MenuItem> GetAvailable()
        {
            var list = new List<MenuItem>();
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT m.Id, m.Name, m.Description, m.Price, m.CategoryId, c.Name AS CategoryName, 
                       m.ImagePath, m.IsAvailable, m.IsActive, m.CreatedAt
                FROM MenuItems m
                LEFT JOIN Categories c ON m.CategoryId = c.Id
                WHERE m.IsActive = 1 AND m.IsAvailable = 1
                ORDER BY c.Name ASC, m.Name ASC;";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(MapMenuItem(reader));
            }
            return list;
        }

        public List<MenuItem> SearchAndFilter(string? keyword, int? categoryId, bool onlyAvailable = false)
        {
            var list = new List<MenuItem>();
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();

            string sql = @"
                SELECT m.Id, m.Name, m.Description, m.Price, m.CategoryId, c.Name AS CategoryName, 
                       m.ImagePath, m.IsAvailable, m.IsActive, m.CreatedAt
                FROM MenuItems m
                LEFT JOIN Categories c ON m.CategoryId = c.Id
                WHERE m.IsActive = 1 ";

            if (onlyAvailable)
            {
                sql += " AND m.IsAvailable = 1 ";
            }

            if (categoryId.HasValue && categoryId.Value > 0)
            {
                sql += " AND m.CategoryId = @catId ";
                cmd.Parameters.AddWithValue("@catId", categoryId.Value);
            }

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                sql += " AND (m.Name LIKE @kw OR m.Description LIKE @kw) ";
                cmd.Parameters.AddWithValue("@kw", $"%{keyword.Trim()}%");
            }

            sql += " ORDER BY c.Name ASC, m.Name ASC;";
            cmd.CommandText = sql;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(MapMenuItem(reader));
            }
            return list;
        }

        public MenuItem? GetById(int id)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT m.Id, m.Name, m.Description, m.Price, m.CategoryId, c.Name AS CategoryName, 
                       m.ImagePath, m.IsAvailable, m.IsActive, m.CreatedAt
                FROM MenuItems m
                LEFT JOIN Categories c ON m.CategoryId = c.Id
                WHERE m.Id = @id;";
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MapMenuItem(reader);
            }
            return null;
        }

        public int Add(MenuItem item)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO MenuItems (Name, Description, Price, CategoryId, ImagePath, IsAvailable, IsActive, CreatedAt)
                VALUES (@name, @desc, @price, @catId, @img, @avail, 1, @created);
                SELECT last_insert_rowid();";

            cmd.Parameters.AddWithValue("@name", item.Name.Trim());
            cmd.Parameters.AddWithValue("@desc", item.Description?.Trim() ?? string.Empty);
            cmd.Parameters.AddWithValue("@price", (double)item.Price);
            cmd.Parameters.AddWithValue("@catId", item.CategoryId);
            cmd.Parameters.AddWithValue("@img", item.ImagePath ?? string.Empty);
            cmd.Parameters.AddWithValue("@avail", item.IsAvailable ? 1 : 0);
            cmd.Parameters.AddWithValue("@created", item.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));

            long newId = (long)(cmd.ExecuteScalar() ?? 0L);
            item.Id = (int)newId;
            return item.Id;
        }

        public bool Update(MenuItem item)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE MenuItems
                SET Name = @name, Description = @desc, Price = @price, CategoryId = @catId,
                    ImagePath = @img, IsAvailable = @avail
                WHERE Id = @id;";

            cmd.Parameters.AddWithValue("@name", item.Name.Trim());
            cmd.Parameters.AddWithValue("@desc", item.Description?.Trim() ?? string.Empty);
            cmd.Parameters.AddWithValue("@price", (double)item.Price);
            cmd.Parameters.AddWithValue("@catId", item.CategoryId);
            cmd.Parameters.AddWithValue("@img", item.ImagePath ?? string.Empty);
            cmd.Parameters.AddWithValue("@avail", item.IsAvailable ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", item.Id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool ToggleAvailability(int id, bool isAvailable)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE MenuItems SET IsAvailable = @avail WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@avail", isAvailable ? 1 : 0);
            cmd.Parameters.AddWithValue("@id", id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool IsInOrders(int menuItemId)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM OrderItems WHERE MenuItemId = @id;";
            cmd.Parameters.AddWithValue("@id", menuItemId);
            long count = (long)(cmd.ExecuteScalar() ?? 0L);
            return count > 0;
        }

        // FR-6.5: If the item appears in past orders, deactivate it instead of erasing it, so order history stays intact.
        public bool DeleteOrDeactivate(int id, out bool wasDeactivated)
        {
            wasDeactivated = false;
            using var conn = DatabaseHelper.GetConnection();

            if (IsInOrders(id))
            {
                // Soft delete
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE MenuItems SET IsActive = 0, IsAvailable = 0 WHERE Id = @id;";
                cmd.Parameters.AddWithValue("@id", id);
                wasDeactivated = true;
                return cmd.ExecuteNonQuery() > 0;
            }
            else
            {
                // Hard delete
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM MenuItems WHERE Id = @id;";
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public int GetTotalActiveCount()
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM MenuItems WHERE IsActive = 1;";
            return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
        }

        private static MenuItem MapMenuItem(SqliteDataReader reader)
        {
            return new MenuItem
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                Description = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                Price = Convert.ToDecimal(reader.GetDouble(3)),
                CategoryId = reader.GetInt32(4),
                CategoryName = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                ImagePath = reader.IsDBNull(6) ? null : reader.GetString(6),
                IsAvailable = reader.GetInt32(7) == 1,
                IsActive = reader.GetInt32(8) == 1,
                CreatedAt = reader.IsDBNull(9) ? DateTime.Now : DateTime.Parse(reader.GetString(9))
            };
        }
    }
}
