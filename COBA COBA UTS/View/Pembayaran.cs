using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using COBA_COBA_UTS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace COBA_COBA_UTS
{
    public partial class Pembayaran : Form
    {
        private BelanjaController belanjaController;
        private Homepage homepage;
        private Payment payment;
        public Pembayaran(Homepage homepage, Payment payment)
        {
            InitializeComponent();
            belanjaController = new BelanjaController(new DbContext());
            LoadProducts();
            this.homepage = homepage;
            this.payment = payment;
            IsiComboBox();
            IsiComboBox1();

        }
        private void LoadProducts()
        {
            List<Payment> paymentItems = belanjaController.GetAllProductsInPayment();

            foreach (Payment paymentItem in paymentItems)
            {
                Produk product = belanjaController.GetProductById(paymentItem.Id_produk);

                if (product != null)
                {

                    UserControl3 newProductControl = new UserControl3(homepage, paymentItem);

                    newProductControl.ProductImage = belanjaController.GetImageFromBlob(product.FotoData);
                    newProductControl.ProductNames = product.Nama;
                    newProductControl.ProductJumlah = paymentItem.Jumlah; // Update this based on the properties in the Payment object
                    newProductControl.ProductPrice = paymentItem.SubPrice.ToString();

                    flowLayoutPanel1.Controls.Add(newProductControl);
                }
            }
        }
        private void IsiComboBox()
        {
            // Pastikan bahwa controller tidak null sebelum digunakan
            if (belanjaController != null)
            {
                // Mengisi data combo box
                DataTable getPromo = belanjaController.GetPromo();
                comboBox1.DataSource = getPromo;
                comboBox1.DisplayMember = "KodePromo";
            }
            else
            {
                // Handle jika controller null
                MessageBox.Show("Controller belum diinisialisasi dengan benar.");
            }
        }
        private void IsiComboBox1()
        {
            // Pastikan bahwa controller tidak null sebelum digunakan
            if (belanjaController != null)
            {
                // Mengisi data combo box
                DataTable getEkspedisi = belanjaController.GetEkspedisi();
                comboBox2.DataSource = getEkspedisi;
                comboBox2.DisplayMember = "jenis";
            }
            else
            {
                // Handle jika controller null
                MessageBox.Show("Controller belum diinisialisasi dengan benar.");
            }
        }

   

        private void Bayar_Click(object sender, EventArgs e)
        {
            CalculateTotal();
            QR qR = new QR();
            qR.Show();
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (belanjaController != null)
            {
                // Mendapatkan harga dari sumber data yang sesuai, misalnya dari method GetEkspedisiValue
                string selectedEkspedisi = comboBox2.Text;
                float hargaEkspedisi = belanjaController.GetEkspedisiValue(selectedEkspedisi);

                // Set nilai harga ke TextBox2
                textBox2.Text = hargaEkspedisi.ToString();
            }
            else
            {
                // Handle jika controller null
                MessageBox.Show("Controller belum diinisialisasi dengan benar.");
            }
        }

        private int lastLabelY = 0;
        private void CalculateTotal()
        {
            float subtotal = 0;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is UserControl3 userControl3)
                {
                    string productName = userControl3.ProductNames;
                    int productQuantity = int.Parse(userControl3.ProductJumlah);
                    float productPrice = float.Parse(userControl3.ProductPrice.Substring(3));

                    // Add the individual product prices
                    subtotal += productPrice * productQuantity;

                    Payment newPayment = new Payment
                    {
                        Nama = productName,
                        Jumlah = productQuantity.ToString(),
                        Harga = productPrice.ToString(),
                     
                    };

                    // Call the controller method to add the current item to the payment
                    int paymentResult = belanjaController.AddToHistory(newPayment);

                }
            }

            string selectedPromo = comboBox1.Text;
            float promoValue = belanjaController.GetPromoValue(selectedPromo);

            string selectedEkspedisi = comboBox2.Text;
            float expeditionValue = belanjaController.GetEkspedisiValue(selectedEkspedisi);

            float totalBayarWithEkspedisi = subtotal + expeditionValue;
            float totalAfterDiscount = totalBayarWithEkspedisi - totalBayarWithEkspedisi * promoValue;

            float total = totalAfterDiscount;

            float subPrice = totalBayarWithEkspedisi;
            float ongkir = expeditionValue;
            float diskon = promoValue * 100; // Diskon dalam persen

            // Menampilkan promo, ongkir, dan total ke dalam Panel3
            AddInfoToPanel($"Promo      : {diskon.ToString("N2")}%");
            AddInfoToPanel($"Ongkir     : Rp {ongkir.ToString("N2")}");
            AddInfoToPanel($"Total      : Rp {total.ToString("N2")}");
        }

        private void AddInfoToPanel(string info)
        {
            Label infoLabel = new Label();
            infoLabel.Text = info;
            infoLabel.AutoSize = true;

            // Menambahkan label ke dalam Panel3
            panel3.Controls.Add(infoLabel);
            infoLabel.Location = new Point(0, lastLabelY); // Mengatur posisi Y dari label

            // Menyesuaikan posisi Y untuk label berikutnya
            lastLabelY += infoLabel.Height + 2; // Sesuaikan nilai jarak di sini
        }


    }
}
