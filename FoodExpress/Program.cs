using System;
using System.Windows.Forms;
using FoodExpress.Data;
using FoodExpress.Views;

namespace FoodExpress
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the FoodExpress application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set high DPI settings and default fonts
            ApplicationConfiguration.Initialize();

            try
            {
                // Initialize SQLite database schema and seed initial data
                DatabaseHelper.InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database initialization failed: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start application at the Login Screen
            Application.Run(new LoginForm());
        }    
    }
}
