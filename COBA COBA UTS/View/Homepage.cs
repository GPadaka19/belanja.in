using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBA_COBA_UTS
{
    public partial class Homepage : Form
    {
        private BelanjaController belanjaController; // Tambahkan deklarasi BelanjaController
        public Homepage()
        {
            InitializeComponent();
            belanjaController = new BelanjaController(new DbContext()); 
            LoadProducts();
            LoadUsername();
        }
        public string GetIconButton2Text()
        {
            return iconButton2.Text;
        }
        public void RefreshHomepage()
        {
            // Membersihkan kontrol yang ada pada flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            // Memuat kembali produk atau data yang diperlukan
            LoadProducts();
            LoadUsername(); // Memuat kembali username
        }
        // Metode yang memuat nama pengguna
        public void LoadUsername()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Username))
            {
                Properties.Settings.Default.Username = "Login";
                Properties.Settings.Default.Save();
            }

            // Setel nilai iconButton2.Text ke nilai yang tersimpan di pengaturan
            iconButton2.Text = Properties.Settings.Default.Username;
        }
        public void SetButtonUsername(string username)
        {
            iconButton2.Text = username;
        }


        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage(this);
            loginPage.Show();
        }

        private void Cari_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();
            flowLayoutPanel1.Controls.Clear();
            if (!string.IsNullOrEmpty(searchTerm))
            {

                List<Produk> searchResults = belanjaController.ReadByNama(searchTerm);
               
                DisplaySearchResults(searchResults);
            }
            else
            {
                LoadProducts();
            }
        }
        private void LoadProducts()
        {
            List<Produk> products = belanjaController.GetAllProducts();

            foreach (Produk product in products)
            {
                // Create a new UserControl1 instance
                UserControl1 newProductControl = new UserControl1(this);

                // Set product information in the UserControl1 instance
                newProductControl.ProductImage = belanjaController.GetImageFromBlob(product.FotoData);
                newProductControl.ProductNames = product.Nama;
                newProductControl.ProductStock = product.Stock;
                newProductControl.ProductPrice = product.Harga;

                // Add the newProductControl to the flowLayoutPanel1
                flowLayoutPanel1.Controls.Add(newProductControl);
            }
        }


        private void DisplaySearchResults(List<Produk> searchResults)
        {

            foreach (var product in searchResults)
            {
                UserControl1 newProductControl = new UserControl1(this);

                // Set product information in the UserControl1 instance
                newProductControl.ProductImage = belanjaController.GetImageFromBlob(product.FotoData);
                newProductControl.ProductNames = product.Nama;
                newProductControl.ProductStock = product.Stock;
                newProductControl.ProductPrice = product.Harga;

                // Add the newProductControl to the flowLayoutPanel1
                flowLayoutPanel1.Controls.Add(newProductControl);
            }
        }

    }
}
