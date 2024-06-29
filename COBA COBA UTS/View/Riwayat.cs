using COBA_COBA_UTS.Controller;
using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBA_COBA_UTS.View
{
    public partial class Riwayat : Form
    {
        private BelanjaController belanjaController;
        public Riwayat()
        {
            InitializeComponent();
            belanjaController = new BelanjaController(new DbContext());
            LoadHistory();

            // Mendapatkan nilai-nilai yang sesuai dari sumber lain
            string username = "get_username_from_database_or_session";
            string namaProduk = "NamaProduk";
        }

        private void LoadHistory()
        {
            try
            {
                List<History> historyList = belanjaController.GetHistory();

                foreach (History history in historyList)
                {
                    using (UserControl5 newHistoryControl = new UserControl5())
                    {
                        newHistoryControl.ProductImage = belanjaController.GetImageFromBlob(history.FotoData);
                        newHistoryControl.ProductNames = history.Nama;
                        newHistoryControl.ProductJumlah = history.Jumlah;
                        newHistoryControl.ProductPrice = history.Harga;

                        flowLayoutPanel1.Controls.Add(newHistoryControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
