using COBA_COBA_UTS.Model.Entity;
using COBA_COBA_UTS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COBA_COBA_UTS
{
    public partial class Form1 : Form
    {
        private int borderSize = 2;
        private User user; // Declare the 'user' variable here
        private Homepage homepage;
        private Cart cart;
        private Payment payment;

        public Form1()
        {
            InitializeComponent();
            CollapseMenu();
            loadform(new Homepage());
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(35, 45, 63);
            user = new User(); // Replace 'User()' with the appropriate constructor if available
            homepage = new Homepage();
            cart = new Cart();
            payment = new Payment();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                    {
                        this.Padding = new Padding(borderSize);
                    }
                    break;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                Logo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                Logo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton.Tag != null)
                    {
                        menuButton.Text = "  " + menuButton.Tag.ToString();
                        menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                        menuButton.Padding = new Padding(10, 0, 0, 0);
                    }
                }
            }
        }
        private void ClearMainPanel()
        {
            foreach (Control control in mainpanel.Controls.OfType<Form>().ToList())
            {
                control.Dispose();
                control.Dispose();
                control.Dispose();
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ClearMainPanel();
            label1.Text = "Homepage";
            loadform(new Homepage());

        }
        private void btnKeranjang_Click(object sender, EventArgs e)
        {
           /* if(homepage.GetIconButton2Text() != "Login")
            {*/
            ClearMainPanel();
            label1.Text = "Keranjang";
            loadform(new Keranjang(homepage));
           /* }
            else
            {
                MessageBox.Show("Silahkan login terlebih dahulu!");
            }*/
        }
        public void btnPembayaran_Click(object sender, EventArgs e)
        {
            label1.Text = "Payment";
            ClearMainPanel();
            loadform(new Pembayaran(homepage,payment));
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            label1.Text = "History";
            ClearMainPanel();
            loadform(new Riwayat());
        }
        private void btnTentang_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Tentang";
            ClearMainPanel();
            loadform(new Tentang());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogoutPage logoutPage = new LogoutPage(homepage); // Pass required parameters
            logoutPage.Show();
        }
    }
}
