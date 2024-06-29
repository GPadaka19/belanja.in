using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.IO;
using System.Net;
using System.Drawing;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Data;
using COBA_COBA_UTS.View;

namespace COBA_COBA_UTS.Model.Repository
{
    public class BelanjaRepository
    {
        private SQLiteConnection _conn;

        public BelanjaRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public Image GetImageFromBlob(byte[] blob)
        {
            if (blob != null)
            {
                using (var ms = new System.IO.MemoryStream(blob))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            return null; // Jika tidak ada data gambar, kembalikan null atau gambar default
        }

        public List<Produk> GetAllProducts()
        {
            List<Produk> products = new List<Produk>();

            string sql = "SELECT * FROM produk";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                try
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produk product = new Produk
                            {
                                Id_produk = Convert.ToInt32(reader["id_produk"]),
                                Nama = reader["nama"].ToString(),
                                Stock = reader["stock"].ToString(),
                                Harga = reader["harga"].ToString(),
                                FotoData = reader["foto"] as byte[] // Ambil data BLOB dari kolom foto
                            };

                            products.Add(product);
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    // Handle exception or log error
                    Console.WriteLine(ex.Message);
                }
            }

            return products;
        }
        public List<Cart> GetAllProductsInCart()
        {
            string username = Properties.Settings.Default.Username;
            List<Cart> productsInCart = new List<Cart>();

            string sql = "SELECT p.id_produk, p.nama, p.harga, p.foto, k.id_keranjang, k.jumlah " +
                         "FROM produk p " +
                         "JOIN keranjang k ON p.id_produk = k.id_produk " +
                         "WHERE k.username = @Username";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cart cartItem = new Cart
                            {
                                Id_produk = reader["id_produk"].ToString(),
                                Nama = reader["nama"].ToString(),
                                Harga = reader["harga"].ToString(),
                                FotoData = reader["foto"] as byte[],
                                Id_Keranjang = reader["id_keranjang"].ToString(),
                                Jumlah = Convert.ToDecimal(reader["jumlah"])
                            };

                            productsInCart.Add(cartItem);
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    // Handle exception or log error
                    Console.WriteLine(ex.Message);
                }
            }

            return productsInCart;
        }

        public List<History> GetHistory()
        {
            string username = Properties.Settings.Default.Username;
            List<History> historyList = new List<History>();
            string sql = "SELECT p.id_produk, p.nama, p.harga, p.foto, k.id_keranjang, pe.jumlah, pe.subtotal, pe.total " +
                         "FROM produk p " +
                         "JOIN keranjang k ON p.id_produk = k.id_produk " +
                         "JOIN pembayaran pe ON p.id_produk = pe.id_produk AND k.id_keranjang = pe.id_keranjang " +
                         "WHERE k.username = @Username";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                try
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            History historyItem = new History
                            {
                                Id_produk = reader["id_produk"].ToString(),
                                Nama = reader["nama"].ToString(),
                                Harga = reader["harga"].ToString(),
                                FotoData = reader["foto"] as byte[],
                                Id_Keranjang = reader["id_keranjang"].ToString(),
                                Jumlah = reader["jumlah"].ToString(),
                                Total = reader["total"].ToString(),
                            };

                            historyList.Add(historyItem);
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    // Handle exception or log error
                    Console.WriteLine(ex.Message);
                }
            }

            return historyList;
        }


        public List<Payment> GetAllProductsInPayment()
        {
            string username = Properties.Settings.Default.Username;
            List<Payment> productsInPayment = new List<Payment>();

            string sql = "SELECT p.id_produk, p.nama, p.harga, p.foto, k.id_keranjang, pe.jumlah, pe.subtotal, pe.total " +
                         "FROM produk p " +
                         "JOIN keranjang k ON p.id_produk = k.id_produk " +
                         "JOIN pembayaran pe ON p.id_produk = pe.id_produk AND k.id_keranjang = pe.id_keranjang " +
                         "WHERE k.username = @Username";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                try
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Payment paymentItem = new Payment
                            {
                                Id_produk = reader["id_produk"].ToString(),
                                Nama = reader["nama"].ToString(),
                                Harga = reader["harga"].ToString(),
                                FotoData = reader["foto"] as byte[],
                                Id_Keranjang = reader["id_keranjang"].ToString(),
                                Jumlah = reader["jumlah"].ToString(),
                                Total = reader["total"].ToString(),
                                SubPrice = Convert.ToDecimal(reader["subtotal"])
                            };

                            productsInPayment.Add(paymentItem);
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    // Handle exception or log error
                    Console.WriteLine(ex.Message);
                }
            }

            return productsInPayment;
        }
        public decimal GetPriceByProductId(string productId)
        {
            decimal price = 0;

            string query = "SELECT harga FROM produk WHERE id_produk = @id_produk";

            using (SQLiteCommand cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@id_produk", productId);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    // Assuming 'harga' is a decimal column in the database
                    price = Convert.ToDecimal(result);
                }
            }

            return price;
        }
        public Produk ReadById(string keyword)
        {
            Produk product = null;

            string query = "SELECT * FROM produk WHERE id_produk = @id_produk ";

            using (SQLiteCommand cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@id_produk", keyword);


                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Produk
                        {
                            Id_produk = Convert.ToInt32(reader["id_produk"]),
                            Nama = reader["nama"].ToString(),
                            Stock = reader["stock"].ToString(),
                            Harga = reader["harga"].ToString(),
                            FotoData = reader["foto"] as byte[]
                        };
                    }
                }
            }

            return product;
        }

        public List<Produk> ReadByNama(string keyword)
        {
            List<Produk> searchResults = new List<Produk>();

            // Query untuk melakukan pencarian data berdasarkan keyword di dalam tabel produk
            string query = "SELECT * FROM produk WHERE nama LIKE @keyword";

            using (SQLiteCommand cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%"); // Gunakan LIKE untuk mencari kata yang mengandung keyword

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produk product = new Produk
                        {
                            Id_produk = Convert.ToInt32(reader["id_produk"]),
                            Nama = reader["nama"].ToString(),
                            Stock = reader["stock"].ToString(),
                            Harga = reader["harga"].ToString(),
                            FotoData = reader["foto"] as byte[] // Ambil data BLOB dari kolom foto
                        };

                        searchResults.Add(product);
                    }
                }
            }

            return searchResults;
        }

        public int AddToCart(Produk product)
        {
            string username = Properties.Settings.Default.Username;
            string userId = "";

            string queryGetUserId = "SELECT username FROM akun WHERE Username = @Username";

            using (SQLiteCommand getUserIdCommand = new SQLiteCommand(queryGetUserId, _conn))
            {
                getUserIdCommand.Parameters.AddWithValue("@Username", username);
                object userIdResult = getUserIdCommand.ExecuteScalar();

                if (userIdResult != null && userIdResult != DBNull.Value)
                {
                    userId = Convert.ToString(userIdResult);
                }
                else
                {
                    return -1; // User not found
                }
            }
            int productId = -1;

            string queryGetProductId = "SELECT Id_Produk FROM produk WHERE Nama = @Nama";

            using (SQLiteCommand command = new SQLiteCommand(queryGetProductId, _conn))
            {
                command.Parameters.AddWithValue("@Nama", product.Nama);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    productId = Convert.ToInt32(result);
                }
            }

            if (productId == -1)
            {
                return -1;
            }

            string queryCheckProductInCart = "SELECT Id_Produk FROM Keranjang WHERE Id_Produk = @Id_Produk AND Username = @Username";

            using (SQLiteCommand checkCommand = new SQLiteCommand(queryCheckProductInCart, _conn))
            {
                checkCommand.Parameters.AddWithValue("@Id_Produk", productId);
                checkCommand.Parameters.AddWithValue("@Username", userId); // Pastikan userId adalah nilai username yang valid

                object existingResult = checkCommand.ExecuteScalar();

                // Mengecek apakah produk sudah ada di keranjang
                if (existingResult != null && existingResult != DBNull.Value)
                {
                    string queryUpdateCart = "UPDATE Keranjang SET Jumlah = Jumlah + 1 WHERE Id_Produk = @Id_Produk AND Username = @Username";

                    using (SQLiteCommand updateCommand = new SQLiteCommand(queryUpdateCart, _conn))
                    {
                        updateCommand.Parameters.AddWithValue("@Id_Produk", productId);
                        updateCommand.Parameters.AddWithValue("@Username", userId); // Pastikan userId adalah nilai username yang valid
                        return updateCommand.ExecuteNonQuery(); // Mengembalikan jumlah baris yang berhasil diupdate
                    }
                }
                else // Jika produk belum ada di keranjang
                {
                    string queryInsertToCart = "INSERT INTO Keranjang (Id_Produk, Jumlah, Subtotal, Username) VALUES (@Id_Produk, 1, @Subtotal, @Username)";

                    using (SQLiteCommand insertCommand = new SQLiteCommand(queryInsertToCart, _conn))
                    {
                        insertCommand.Parameters.AddWithValue("@Id_Produk", productId);
                        insertCommand.Parameters.AddWithValue("@Subtotal", product.Harga);
                        insertCommand.Parameters.AddWithValue("@Username", userId); // Pastikan userId adalah nilai username yang valid
                        return insertCommand.ExecuteNonQuery(); // Mengembalikan jumlah baris yang berhasil diinsert
                    }
                }
            }
        }
        public int AddToPayment(Cart cart)
        {
            string username = Properties.Settings.Default.Username;
            string userId = "";

            string queryGetUserId = "SELECT username FROM akun WHERE Username = @Username";

            using (SQLiteCommand getUserIdCommand = new SQLiteCommand(queryGetUserId, _conn))
            {
                getUserIdCommand.Parameters.AddWithValue("@Username", username);
                object userIdResult = getUserIdCommand.ExecuteScalar();

                if (userIdResult != null && userIdResult != DBNull.Value)
                {
                    userId = Convert.ToString(userIdResult);
                }
                else
                {
                    return -1; // User not found
                }
            }
            string queryGetProductId = "SELECT Id_Produk FROM produk WHERE Nama = @Nama";

            int productId;
            using (SQLiteCommand command = new SQLiteCommand(queryGetProductId, _conn))
            {
                command.Parameters.AddWithValue("@Nama", cart.Nama);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    productId = Convert.ToInt32(result);
                }
                else
                {
                    return -1; 
                }
            }

            int idKeranjang = -1;
            string query = "SELECT id_keranjang FROM keranjang WHERE id_produk = @Id_Produk AND Username = @Username";

            using (SQLiteCommand command = new SQLiteCommand(query, _conn))
            {
                command.Parameters.AddWithValue("@Id_Produk", productId);
                command.Parameters.AddWithValue("@Username", userId);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    idKeranjang = Convert.ToInt32(result);
                }

            }

            string queryInsertToCart = "INSERT INTO pembayaran (Id_Produk, id_keranjang, Jumlah, Subtotal, username) VALUES (@Id_Produk,@id_keranjang, @jumlah, @Subtotal, @Username)";

            using (SQLiteCommand insertCommand = new SQLiteCommand(queryInsertToCart, _conn))
            {

                insertCommand.Parameters.AddWithValue("@Id_Produk", productId);
                insertCommand.Parameters.AddWithValue("@id_keranjang", idKeranjang);
                insertCommand.Parameters.AddWithValue("@jumlah", cart.Jumlah);
                insertCommand.Parameters.AddWithValue("@Subtotal", cart.SubPrice);
                insertCommand.Parameters.AddWithValue("@Username", userId);
                return insertCommand.ExecuteNonQuery(); // Mengembalikan jumlah baris yang berhasil diinsert
            }


        }
        public int AddToHistory(Payment payment)
        {
            string username = Properties.Settings.Default.Username;
            string userId = "";

            string queryGetUserId = "SELECT username FROM akun WHERE Username = @Username";

            using (SQLiteCommand getUserIdCommand = new SQLiteCommand(queryGetUserId, _conn))
            {
                getUserIdCommand.Parameters.AddWithValue("@Username", username);
                object userIdResult = getUserIdCommand.ExecuteScalar();

                if (userIdResult != null && userIdResult != DBNull.Value)
                {
                    userId = Convert.ToString(userIdResult);
                }
                else
                {
                    return -1; // User not found
                }
            }
            string queryGetProductId = "SELECT Id_Produk FROM produk WHERE Nama = @Nama";

            int productId;
            using (SQLiteCommand command = new SQLiteCommand(queryGetProductId, _conn))
            {
                command.Parameters.AddWithValue("@Nama", payment.Nama);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    productId = Convert.ToInt32(result);
                }
                else
                {
                    return -1;
                }
            }

            int idKeranjang = -1;
            string query = "SELECT id_pembayaran FROM pemabayaran WHERE id_produk = @Id_Produk AND Username = @Username";

            using (SQLiteCommand command = new SQLiteCommand(query, _conn))
            {
                command.Parameters.AddWithValue("@Id_Produk", productId);
                command.Parameters.AddWithValue("@Username", userId);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    idKeranjang = Convert.ToInt32(result);
                }

            }
            int idPromo = -1;
            string queryPromo = "SELECT id_promo FROM promo WHERE kodepromo = @kodepromo";
            
            using (SQLiteCommand command = new SQLiteCommand(queryPromo, _conn))
            {
                command.Parameters.AddWithValue("@kodepromo", idPromo);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    idPromo = Convert.ToInt32(result);
                }

            }
            int idEkspedisi = -1;
            string queryEkspedisi = "SELECT id_ekspedisi FROM promo WHERE jenis = @jenis";

            using (SQLiteCommand command = new SQLiteCommand(queryEkspedisi, _conn))
            {
                command.Parameters.AddWithValue("@jenis", idEkspedisi);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    idPromo = Convert.ToInt32(result);
                }

            }
            string queryInsertToCart = "INSERT INTO riwayat (Id_Produk, id_keranjang, datetime, id_promo, id_ekspedisi) VALUES (@Id_Produk,@id_keranjang, @datetime, @id_promo, @id_ekspedisi)";

            using (SQLiteCommand insertCommand = new SQLiteCommand(queryInsertToCart, _conn))
            {

                insertCommand.Parameters.AddWithValue("@Id_Produk", productId);
                insertCommand.Parameters.AddWithValue("@id_keranjang", idKeranjang);
                insertCommand.Parameters.AddWithValue("@datetime", payment.tanggal);
                insertCommand.Parameters.AddWithValue("@id_promo", payment.SubPrice);
                insertCommand.Parameters.AddWithValue("@id_ekspedisi", payment.Id_ekspedisi);
                return insertCommand.ExecuteNonQuery(); // Mengembalikan jumlah baris yang berhasil diinsert
            }


        }
        public bool UpdateStock(Cart cart)
        {
            // Mengambil stok saat ini dari database berdasarkan Id_Produk
            decimal currentStock = GetCurrentStockFromDatabase(cart.Id_produk);

            // Mengurangi stok berdasarkan jumlah barang yang ada di dalam keranjang
            decimal updatedStock = currentStock - cart.Jumlah;

            string query = "UPDATE produk SET stock = @stock WHERE Id_Produk = @Id_Produk";

            using (SQLiteCommand command = new SQLiteCommand(query, _conn))
            {
                command.Parameters.AddWithValue("@stock", updatedStock);
                command.Parameters.AddWithValue("@Id_Produk", cart.Id_produk);

                int rowsUpdated = command.ExecuteNonQuery();

                // Jika rowsUpdated lebih dari 0, artinya pembaruan berhasil
                return rowsUpdated > 0;
            }
        }

        private decimal GetCurrentStockFromDatabase(string productId)
        {
            decimal currentStock = 0;

            string query = "SELECT stock FROM produk WHERE Id_Produk = @Id_Produk";

            using (SQLiteCommand command = new SQLiteCommand(query, _conn))
            {
                command.Parameters.AddWithValue("@Id_Produk", productId);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    // Konversi nilai dari database ke dalam tipe data yang sesuai
                    currentStock = Convert.ToDecimal(result);
                }
            }

            return currentStock;
        }

        public bool UpdateCart(Cart cart)
        {
            string query = "UPDATE Keranjang SET Jumlah = @Jumlah, Subtotal = @Subtotal WHERE Id_Produk = @Id_Produk";

            using (SQLiteCommand command = new SQLiteCommand(query, _conn))
            {
                command.Parameters.AddWithValue("@Jumlah", cart.Jumlah);
                command.Parameters.AddWithValue("@Subtotal", cart.SubPrice);
                command.Parameters.AddWithValue("@Id_Produk", cart.Id_produk);

                int rowsUpdated = command.ExecuteNonQuery();

                // Jika rowsUpdated lebih dari 0, artinya pembaruan berhasil
                return rowsUpdated > 0;
            }
        }

        public bool DeleteProductFromCart(string id_produk)
        {
            string sql = @"DELETE FROM keranjang WHERE id_produk = @id_produk";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_produk", id_produk);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        public bool DeleteProductFromPayment(string id_produk)
        {
            string sql = @"DELETE FROM pembayaran WHERE id_produk = @id_produk";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id_produk", id_produk);

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
        public DataTable GetPromo()
        {
            string sql = "SELECT KodePromo FROM promo";
            using (SQLiteCommand query = new SQLiteCommand(sql, _conn))
            {
                using (SQLiteDataAdapter sd = new SQLiteDataAdapter(query))
                {
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    return dt;
                }
            }
        }
        public float GetPromoValue(string promoCode)
        {
            float promoValue = 0;

            try
            {


                string sql = $"SELECT potongan FROM promo WHERE KodePromo = '{promoCode}'";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // Use ExecuteScalar to get a single value
                    object result = cmd.ExecuteScalar();

                    if (result != null && float.TryParse(result.ToString(), out promoValue))
                    {
                        // Value successfully parsed
                        return promoValue;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                // Handle exception or log error
                Console.WriteLine("Error executing SQL command: " + ex.Message);
            }


            // Return 0 if there's an error or no promo value found
            return promoValue;
        }
        public DataTable GetEkspedisi()
        {
            string sql = "SELECT jenis FROM ekspedisi";
            using (SQLiteCommand query = new SQLiteCommand(sql, _conn))
            {
                using (SQLiteDataAdapter sd = new SQLiteDataAdapter(query))
                {
                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    return dt;
                }
            }
        }
        public float GetEkspedisiValue(string Ekspedision)
        {
            float promoValue = 0;

            try
            {
                string sql = $"SELECT harga FROM ekspedisi WHERE jenis = '{Ekspedision}'";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && float.TryParse(result.ToString(), out promoValue))
                    {
                        return promoValue;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Error executing SQL command: " + ex.Message);
            }

            return promoValue;
        }

    }
}
