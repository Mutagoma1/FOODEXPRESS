using System;
using System.Drawing;
using System.Windows.Forms;
using FoodExpress.Controllers;

namespace FoodExpress.Views
{
    public partial class LoginForm : Form
    {
        private readonly AuthController _authController = new AuthController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            var result = _authController.Login(email, password);
            if (!result.Success || result.User == null)
            {
                lblError.Text = result.Message;
                return;
            }

            // Hide login form and route to appropriate main form (FR-1.6)
            this.Hide();

            if (result.User.IsAdmin)
            {
                using var adminForm = new MainAdminForm();
                adminForm.ShowDialog();
            }
            else
            {
                using var customerForm = new MainCustomerForm();
                customerForm.ShowDialog();
            }

            // Reset inputs on return
            txtPassword.Clear();
            lblError.Text = string.Empty;
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            using var regForm = new RegisterForm();
            regForm.ShowDialog();
            this.Show();
        }

        private void btnQuickCustomer_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "caleb@example.com";
            txtPassword.Text = "Password123!";
            btnLogin.PerformClick();
        }

        private void btnQuickAdmin_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "admin@foodexpress.com";
            txtPassword.Text = "Admin123!";
            btnLogin.PerformClick();
        }
    }
}
