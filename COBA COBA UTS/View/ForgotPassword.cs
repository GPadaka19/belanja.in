using COBA_COBA_UTS.Controller; // Pastikan namespace sudah diimpor dengan benar
using System.Windows.Forms;
using System;
using COBA_COBA_UTS.Model.Context;

namespace COBA_COBA_UTS
{
    public partial class ForgotPassword : Form
    {
        private UserController controller;
        private Homepage homepage;

        public ForgotPassword(UserController controller,Homepage homepage)
        {
            InitializeComponent();
            this.controller = controller;
            this.homepage = homepage;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text; // Get email from the TextBox
            string username = controller.ShowPassword(email);
            string password = controller.ShowPassword(email); // Retrieve password using the controller

            if (!string.IsNullOrEmpty(password))
            {
                MessageBox.Show($"Email : {email}\nPassword : {password}");
            }
            else
            {
                MessageBox.Show("Password not found for the provided email.");
            }
        }

        private void BackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage loginpage = new LoginPage(homepage);
            loginpage.Show();
            this.Close();
        }
    }
}
