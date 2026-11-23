using System;
using FoodExpress.Models;
using Microsoft.Data.Sqlite;

namespace FoodExpress.Data.Repositories
{
    public class UserRepository
    {
        public User? GetByEmail(string email)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, FullName, Email, PhoneNumber, PasswordHash, Role, DefaultAddress, CreatedAt FROM Users WHERE LOWER(Email) = LOWER(@email);";
            cmd.Parameters.AddWithValue("@email", email.Trim());

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MapUser(reader);
            }
            return null;
        }

        public User? GetById(int id)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, FullName, Email, PhoneNumber, PasswordHash, Role, DefaultAddress, CreatedAt FROM Users WHERE Id = @id;";
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return MapUser(reader);
            }
            return null;
        }

        public bool ExistsEmail(string email)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE LOWER(Email) = LOWER(@email);";
            cmd.Parameters.AddWithValue("@email", email.Trim());
            long count = (long)(cmd.ExecuteScalar() ?? 0L);
            return count > 0;
        }

        public int CreateUser(User user)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Users (FullName, Email, PhoneNumber, PasswordHash, Role, DefaultAddress, CreatedAt)
                VALUES (@name, @email, @phone, @hash, @role, @addr, @created);
                SELECT last_insert_rowid();";

            cmd.Parameters.AddWithValue("@name", user.FullName.Trim());
            cmd.Parameters.AddWithValue("@email", user.Email.Trim());
            cmd.Parameters.AddWithValue("@phone", user.PhoneNumber.Trim());
            cmd.Parameters.AddWithValue("@hash", user.PasswordHash);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@addr", user.DefaultAddress?.Trim() ?? string.Empty);
            cmd.Parameters.AddWithValue("@created", user.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"));

            long newId = (long)(cmd.ExecuteScalar() ?? 0L);
            user.Id = (int)newId;
            return user.Id;
        }

        public bool UpdateProfile(int userId, string fullName, string phone, string defaultAddress, string? newPasswordHash = null)
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();

            if (!string.IsNullOrEmpty(newPasswordHash))
            {
                cmd.CommandText = @"
                    UPDATE Users 
                    SET FullName = @name, PhoneNumber = @phone, DefaultAddress = @addr, PasswordHash = @hash
                    WHERE Id = @id;";
                cmd.Parameters.AddWithValue("@hash", newPasswordHash);
            }
            else
            {
                cmd.CommandText = @"
                    UPDATE Users 
                    SET FullName = @name, PhoneNumber = @phone, DefaultAddress = @addr
                    WHERE Id = @id;";
            }

            cmd.Parameters.AddWithValue("@name", fullName.Trim());
            cmd.Parameters.AddWithValue("@phone", phone.Trim());
            cmd.Parameters.AddWithValue("@addr", defaultAddress?.Trim() ?? string.Empty);
            cmd.Parameters.AddWithValue("@id", userId);

            return cmd.ExecuteNonQuery() > 0;
        }

        public int GetTotalCustomersCount()
        {
            using var conn = DatabaseHelper.GetConnection();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Role = 'Customer';";
            return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
        }

        private static User MapUser(SqliteDataReader reader)
        {
            return new User
            {
                Id = reader.GetInt32(0),
                FullName = reader.GetString(1),
                Email = reader.GetString(2),
                PhoneNumber = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                PasswordHash = reader.GetString(4),
                Role = reader.GetString(5),
                DefaultAddress = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                CreatedAt = reader.IsDBNull(7) ? DateTime.Now : DateTime.Parse(reader.GetString(7))
            };
        }
    }
}
