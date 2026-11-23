using System;
using System.Collections.Generic;
using FoodExpress.Data.Repositories;
using FoodExpress.Models;

namespace FoodExpress.Controllers
{
    public class MenuController
    {
        private readonly MenuItemRepository _menuRepo = new MenuItemRepository();
        private readonly CategoryRepository _categoryRepo = new CategoryRepository();

        public List<Category> GetCategories()
        {
            return _categoryRepo.GetAll();
        }

        public List<MenuItem> GetMenuItems(int? categoryId = null, string? searchKeyword = null, bool onlyAvailable = false)
        {
            return _menuRepo.SearchAndFilter(searchKeyword, categoryId, onlyAvailable);
        }

        public List<MenuItem> GetAllAdminMenuItems()
        {
            return _menuRepo.GetAll(includeInactive: true);
        }

        // FR-6.1: Category Management
        public (bool Success, string Message) AddCategory(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                return (false, "Category name is required.");

            try
            {
                var cat = new Category
                {
                    Name = name.Trim(),
                    Description = description?.Trim() ?? string.Empty
                };
                int id = _categoryRepo.Add(cat);
                return id > 0 ? (true, "Category created successfully!") : (false, "Could not add category.");
            }
            catch (Exception ex)
            {
                return (false, $"Failed to add category: {ex.Message}");
            }
        }

        public (bool Success, string Message) UpdateCategory(int id, string name, string description)
        {
            if (id <= 0)
                return (false, "Invalid category.");

            if (string.IsNullOrWhiteSpace(name))
                return (false, "Category name is required.");

            try
            {
                var cat = new Category
                {
                    Id = id,
                    Name = name.Trim(),
                    Description = description?.Trim() ?? string.Empty
                };
                bool ok = _categoryRepo.Update(cat);
                return ok ? (true, "Category updated successfully!") : (false, "Could not update category.");
            }
            catch (Exception ex)
            {
                return (false, $"Failed to update category: {ex.Message}");
            }
        }

        public (bool Success, string Message) DeleteCategory(int id)
        {
            if (id <= 0)
                return (false, "Invalid category.");

            if (_categoryRepo.HasMenuItems(id))
            {
                return (false, "Cannot delete category because active menu items belong to it. Please reassign or delete the items first.");
            }

            try
            {
                bool ok = _categoryRepo.Delete(id);
                return ok ? (true, "Category deleted successfully!") : (false, "Could not delete category.");
            }
            catch (Exception ex)
            {
                return (false, $"Failed to delete category: {ex.Message}");
            }
        }

        // FR-6.2 & FR-6.6: Add Menu Item
        public (bool Success, string Message) AddMenuItem(string name, string description, decimal price, int categoryId, string? imagePath, bool isAvailable)
        {
            if (string.IsNullOrWhiteSpace(name))
                return (false, "Menu item name is required.");

            if (price <= 0)
                return (false, "Price must be greater than zero.");

            if (categoryId <= 0)
                return (false, "Please select a valid category.");

            try
            {
                var item = new MenuItem
                {
                    Name = name.Trim(),
                    Description = description?.Trim() ?? string.Empty,
                    Price = price,
                    CategoryId = categoryId,
                    ImagePath = imagePath,
                    IsAvailable = isAvailable,
                    IsActive = true,
                    CreatedAt = DateTime.Now
                };

                int newId = _menuRepo.Add(item);
                return newId > 0 ? (true, "Menu item added successfully!") : (false, "Failed to add menu item.");
            }
            catch (Exception ex)
            {
                return (false, $"Error adding menu item: {ex.Message}");
            }
        }

        // FR-6.3 & FR-6.6: Edit Menu Item
        public (bool Success, string Message) UpdateMenuItem(int id, string name, string description, decimal price, int categoryId, string? imagePath, bool isAvailable)
        {
            if (id <= 0)
                return (false, "Invalid menu item.");

            if (string.IsNullOrWhiteSpace(name))
                return (false, "Menu item name is required.");

            if (price <= 0)
                return (false, "Price must be greater than zero.");

            if (categoryId <= 0)
                return (false, "Please select a valid category.");

            try
            {
                var item = new MenuItem
                {
                    Id = id,
                    Name = name.Trim(),
                    Description = description?.Trim() ?? string.Empty,
                    Price = price,
                    CategoryId = categoryId,
                    ImagePath = imagePath,
                    IsAvailable = isAvailable
                };

                bool ok = _menuRepo.Update(item);
                return ok ? (true, "Menu item updated successfully!") : (false, "Failed to update menu item.");
            }
            catch (Exception ex)
            {
                return (false, $"Error updating menu item: {ex.Message}");
            }
        }

        // FR-6.4: Mark item as available or unavailable without deleting it
        public (bool Success, string Message) ToggleAvailability(int id, bool isAvailable)
        {
            if (id <= 0)
                return (false, "Invalid item ID.");

            bool ok = _menuRepo.ToggleAvailability(id, isAvailable);
            string state = isAvailable ? "Available" : "Unavailable";
            return ok ? (true, $"Item marked as {state}.") : (false, "Failed to update item availability.");
        }

        // FR-6.5: Soft delete if in past orders, otherwise delete
        public (bool Success, string Message) DeleteMenuItem(int id)
        {
            if (id <= 0)
                return (false, "Invalid item ID.");

            bool ok = _menuRepo.DeleteOrDeactivate(id, out bool wasDeactivated);
            if (ok)
            {
                if (wasDeactivated)
                {
                    return (true, "Item is associated with past orders, so it was deactivated to keep order history intact.");
                }
                return (true, "Menu item deleted successfully.");
            }

            return (false, "Could not delete menu item.");
        }
    }
}
