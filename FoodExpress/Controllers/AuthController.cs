using System;
using System.Text.RegularExpressions;
using FoodExpress.Common;
using FoodExpress.Data.Repositories;
using FoodExpress.Models;

namespace FoodExpress.Controllers
{
    public class AuthController
    {
        private readonly UserRepository _userRepo = new UserRepository();

        public static User? CurrentUser { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;
        public static bool IsAdmin => CurrentUser != null && CurrentUser.IsAdmin;

        public (bool Success, string Message, User? User) Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return (false, "Please enter both email and password.", null);
            }

            var user = _userRepo.GetByEmail(email.Trim());
            if (user == null)
            {
                return (false, "Invalid email or password.", null);
            }

            bool isPasswordValid = PasswordHelper.VerifyPassword(password, user.PasswordHash);
            if (!isPasswordValid)
            {
                return (false, "Invalid email or password.", null);
            }

            CurrentUser = user;
            return (true, $"Welcome back, {user.FullName}!", user);
        }

        public (bool Success, string Message) Register(string fullName, string email, string phone, string password, string confirmPassword, string address)
        {
            // FR-1.1 & FR-1.2: Validate input fields
            if (string.IsNullOrWhiteSpace(fullName))
                return (false, "Full name is required.");

            if (string.IsNullOrWhiteSpace(email))
                return (false, "Email address is required.");

            // Email format validation
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email.Trim(), emailPattern, RegexOptions.IgnoreCase))
                return (false, "Please enter a valid email address.");

            if (string.IsNullOrWhiteSpace(phone))
                return (false, "Phone number is required.");

            if (string.IsNullOrWhiteSpace(password))
                return (false, "Password is required.");

            // Password minimum strength: minimum 6 characters
            if (password.Length < 6)
                return (false, "Password must be at least 6 characters long.");

            if (password != confirmPassword)
                return (false, "Passwords do not match.");

            // Check email uniqueness
            if (_userRepo.ExistsEmail(email.Trim()))
                return (false, "An account with this email address already exists.");

            string passwordHash = PasswordHelper.HashPassword(password);

            var newUser = new User
            {
                FullName = fullName.Trim(),
                Email = email.Trim().ToLowerInvariant(),
                PhoneNumber = phone.Trim(),
                PasswordHash = passwordHash,
                Role = "Customer", // FR-1.5: default role is Customer
                DefaultAddress = address?.Trim() ?? string.Empty,
                CreatedAt = DateTime.Now
            };

            int id = _userRepo.CreateUser(newUser);
            if (id > 0)
            {
                return (true, "Registration successful! You can now log in.");
            }

            return (false, "Failed to create account. Please try again.");
        }

        public void Logout()
        {
            // FR-1.4: Log out
            CurrentUser = null;
        }

        public (bool Success, string Message) UpdateProfile(string fullName, string phone, string address, string? currentPassword, string? newPassword, string? confirmPassword)
        {
            if (CurrentUser == null)
                return (false, "No active session.");

            if (string.IsNullOrWhiteSpace(fullName))
                return (false, "Full name cannot be empty.");

            if (string.IsNullOrWhiteSpace(phone))
                return (false, "Phone number cannot be empty.");

            string? newPasswordHash = null;

            if (!string.IsNullOrEmpty(newPassword))
            {
                if (string.IsNullOrEmpty(currentPassword))
                    return (false, "Please enter your current password to set a new password.");

                if (!PasswordHelper.VerifyPassword(currentPassword, CurrentUser.PasswordHash))
                    return (false, "Current password is incorrect.");

                if (newPassword.Length < 6)
                    return (false, "New password must be at least 6 characters long.");

                if (newPassword != confirmPassword)
                    return (false, "New passwords do not match.");

                newPasswordHash = PasswordHelper.HashPassword(newPassword);
            }

            bool updated = _userRepo.UpdateProfile(CurrentUser.Id, fullName, phone, address, newPasswordHash);
            if (updated)
            {
                CurrentUser.FullName = fullName.Trim();
                CurrentUser.PhoneNumber = phone.Trim();
                CurrentUser.DefaultAddress = address?.Trim() ?? string.Empty;
                if (!string.IsNullOrEmpty(newPasswordHash))
                {
                    CurrentUser.PasswordHash = newPasswordHash;
                }
                return (true, "Profile updated successfully!");
            }

            return (false, "Failed to update profile.");
        }
    }
}
