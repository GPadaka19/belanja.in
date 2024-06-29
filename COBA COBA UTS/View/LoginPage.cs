using COBA_COBA_UTS.Model.Entity;
using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using System;
using System.Windows.Forms;

namespace COBA_COBA_UTS
{
    public partial class LoginPage : Form
    {
        private UserController controller;
        private Homepage homepage;
        
        public LoginPage(Homepage homepage)
        {
            InitializeComponent();
            controller = new UserController(new DbContext());
            this.homepage = homepage;
        }

        private void ForgotPasswordLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(controller, homepage); // Kirim controller ke ForgotPassword
            forgotPassword.Show();
            this.Close();
        }

        private void SignUpLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp(controller, homepage);
            signUpForm.Show();
            this.Close();

        }

        private void btnLOGIN_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            int result = controller.AuthenticateUser(username, password);

            if (result > 0)
            {

                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Save();
                MessageBox.Show("Login successful!");

                if (homepage != null)
                {
                    homepage.SetButtonUsername(username);
                    homepage.RefreshHomepage();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Homepage reference is null.");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Please try again.");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
