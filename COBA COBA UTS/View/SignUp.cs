using COBA_COBA_UTS.Model.Entity;
using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using System;
using System.Windows.Forms;

namespace COBA_COBA_UTS
{
    public partial class SignUp : Form
    {
        private UserController controller;
        private Homepage homepage; // Declare the Homepage property

        public SignUp(UserController controller, Homepage homepage)
        {
            InitializeComponent();
            this.controller = controller;
            this.homepage = homepage; // Initialize the Homepage property
        }
        private void btnSIGNUP_Click_1(object sender, EventArgs e)
        {
            User newUser = new User
            {
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                Nama = txtName.Text,
                Password = txtPassword.Text
            };

            int result = controller.Create(newUser);

            if (result > 0)
            {
                MessageBox.Show("Registration successful!");
                LoginPage loginPage = new LoginPage(homepage); // Provide required arguments
                loginPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }

        }

        private void AlreadySignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage loginPage = new LoginPage(homepage); // Provide required arguments
            loginPage.Show();
            this.Close();
        }
    }
}
