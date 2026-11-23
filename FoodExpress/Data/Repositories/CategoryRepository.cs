using System;
using System.Collections.Generic;
using FoodExpress.Models;
using Microsoft.Data.Sqlite;

namespace FoodExpress.Data.Repositories
{
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            var list = new List<Category>();
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Name, Description FROM Categories ORDER BY Name ASC;";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Category
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.IsDBNull(2) ? string.Empty : reader.GetString(2)
                });
            }
            return list;
        }

        public Category? GetById(int id)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, Name, Description FROM Categories WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Category
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.IsDBNull(2) ? string.Empty : reader.GetString(2)
                };
            }
            return null;
        }

        public int Add(Category category)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Categories (Name, Description) 
                VALUES (@name, @desc);
                SELECT last_insert_rowid();";
            cmd.Parameters.AddWithValue("@name", category.Name.Trim());
            cmd.Parameters.AddWithValue("@desc", category.Description?.Trim() ?? string.Empty);

            long newId = (long)(cmd.ExecuteScalar() ?? 0L);
            category.Id = (int)newId;
            return category.Id;
        }

        public bool Update(Category category)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Categories SET Name = @name, Description = @desc WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@name", category.Name.Trim());
            cmd.Parameters.AddWithValue("@desc", category.Description?.Trim() ?? string.Empty);
            cmd.Parameters.AddWithValue("@id", category.Id);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool HasMenuItems(int categoryId)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM MenuItems WHERE CategoryId = @catId AND IsActive = 1;";
            cmd.Parameters.AddWithValue("@catId", categoryId);
            long count = (long)(cmd.ExecuteScalar() ?? 0L);
            return count > 0;
        }

        public bool Delete(int categoryId)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Categories WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@id", categoryId);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
