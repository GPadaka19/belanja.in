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

namespace COBA_COBA_UTS
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private BelanjaController belanjaController;
        private Homepage homepage;
        private History history;
        public UserControl5(Homepage homepage, History history)
        {
            InitializeComponent();
            belanjaController = new BelanjaController(new DbContext());
            this.homepage = homepage; // This will assign 'null' to 'homepage'
            this.history = history;
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
    }
}
