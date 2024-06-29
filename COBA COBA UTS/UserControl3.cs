using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
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
    public partial class UserControl3 : UserControl
    {
        private BelanjaController belanjaController;
        private Homepage homepage;
        private Payment payment;
        public UserControl3(Homepage homepage, Payment payment)
        {
            InitializeComponent();
            belanjaController = new BelanjaController(new DbContext());
            this.homepage = homepage; // This will assign 'null' to 'homepage'
            this.payment = payment;
        }
        public Image ProductImage
        {
            get => Foto.Image;
            set => Foto.Image = value;
        }

        public string ProductNames
        {
            get => Nama.Text;
            set => Nama.Text = value;
        }

        public string ProductJumlah
        {
            get => Jumlah.Text;
            set => Jumlah.Text = value;
        }

        public string ProductPrice
        {
            get => Harga.Text;
            set => Harga.Text = "Rp " + value;
        }



        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            string id_produk = payment.Id_produk;

            // Call a method to delete the product from the cart based on the product ID
            bool result = belanjaController.DeleteProductFromPayment(id_produk);

            if (result)
            {
                // Perform actions after successful deletion
                this.Parent.Controls.Remove(this);
                // Other actions after successful deletion
            }
            else
            {
                // Handling for deletion failure
                MessageBox.Show("Failed to delete product from cart.");
            }

        }
    }
}
