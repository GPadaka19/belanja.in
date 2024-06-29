using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using COBA_COBA_UTS.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBA_COBA_UTS.View
{
    public partial class LogoutPage : Form
    {
        private Homepage homepage;


        public LogoutPage(Homepage homepage)
        {
            InitializeComponent();
            this.homepage = homepage;

        }
        private void btnYes_Click_1(object sender, EventArgs e)
        {
            string username = Properties.Settings.Default.Username;

            if (username != "Login")
            {
                username = "Login";
                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Save();
                MessageBox.Show("Log Out successful!");

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
                MessageBox.Show("Failed to Log Out");
            }
        }

        private void btnNo_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
