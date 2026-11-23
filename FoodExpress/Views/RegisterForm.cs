using System;
using System.Drawing;
using System.Windows.Forms;
using FoodExpress.Controllers;

namespace FoodExpress.Views
{
    public partial class RegisterForm : Form
    {
        private readonly AuthController _authController = new AuthController();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            var result = _authController.Register(fullName, email, phone, password, confirm, address);
            if (!result.Success)
            {
                lblError.ForeColor = Color.FromArgb(220, 38, 38);
                lblError.Text = result.Message;
                return;
            }

            MessageBox.Show(result.Message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
