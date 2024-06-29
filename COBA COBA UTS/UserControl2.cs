using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBA_COBA_UTS
{
    public partial class UserControl2 : UserControl
    {
        private BelanjaController belanjaController;
        private Homepage homepage;
        private Cart cart;
        public UserControl2(Homepage homepage, Cart cart)
        {
            InitializeComponent();
            belanjaController = new BelanjaController(new DbContext());
            this.homepage = homepage;
            this.cart = cart;

            // Dapatkan harga produk dari database menggunakan cart.Id_produk
            decimal productPrice = GetProductPriceFromDatabase(cart.Id_produk);

            // Setel nilai Jumlah.Text dengan jumlah dari database
            Jumlah.Text = cart.Jumlah.ToString(); // Anggaplah nilai Jumlah sudah ada di Cart

            // Hitung harga dengan mengalikan harga awal dengan jumlah dari database
            Harga.Text = (decimal.Parse(ProductPrice.Substring(3)) * Jumlah.Value).ToString(); // Pastikan format harga adalah "Rp [nilai]"

            UpdatePriceBasedOnQuantity();
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


        private void iconButton1_Click(object sender, EventArgs e)
        {

            string id_produk = cart.Id_produk;

            // Call a method to delete the product from the cart based on the product ID
            bool result = belanjaController.DeleteProductFromCart(id_produk);

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
        private void UpdatePriceBasedOnQuantity()
        {
            decimal price = GetProductPriceFromDatabase(cart.Id_produk); // Retrieve the price from the database
            cart.Jumlah = Jumlah.Value; // Get the value from the numeric control
            cart.SubPrice = price * cart.Jumlah; // Calculate the subtotal

            // Update the cart with the new quantity and subtotal
            cart.Jumlah = Jumlah.Value;
            cart.SubPrice = cart.SubPrice;

            // Update the cart in the database
            belanjaController.UpdateCart(cart);

            // Display the subtotal in Harga.Text
            Harga.Text = "Rp " + cart.SubPrice.ToString();
        }


        public decimal GetProductPriceFromDatabase(string productId)
        {
            // Logic to fetch the product price from the database using productId
            // For example:
            // Assuming you have a method in your controller to get the price by product ID
            // Replace 'YourControllerMethod' with the actual method from your controller

            decimal price = belanjaController.GetPriceByProductId(productId);

            return price;
        }

        private void Jumlah_ValueChanged(object sender, EventArgs e)
        {
            UpdatePriceBasedOnQuantity();
        }

        private void AddToPaymentButton_Click(object sender, EventArgs e)
        {
            // Retrieve the current quantity and price values
            decimal quantity = Jumlah.Value;
            decimal price = GetProductPriceFromDatabase(cart.Id_produk);
            belanjaController.UpdateStock(cart);

            // Calculate the subtotal for the current cart item
            decimal subtotal = price * quantity;

            // Create a new Cart object representing the current item
            Cart newCart = new Cart
            {
                Nama = ProductNames,
                Jumlah = quantity,
                Harga = ProductPrice,
                SubPrice = subtotal,
                // Other properties as needed
            };

            // Call the controller method to add the current item to the payment
            int paymentResult = belanjaController.AddToPayment(newCart);
            this.Parent.Controls.Remove(this);

            if (paymentResult > 0)
            {
                MessageBox.Show("Product added to Payment successfully! The product has been removed form cart");
                // Perform additional actions if needed after successful addition to payment
            }
            else
            {
                MessageBox.Show("Failed to add product to payment.");
                // Handle the case where adding to payment fails
            }
        }





    }
}