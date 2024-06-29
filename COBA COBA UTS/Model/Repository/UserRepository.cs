using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COBA_COBA_UTS.Model.Repository
{
    internal class UserRepository
    {
        private SQLiteConnection _conn;

        public UserRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(User user)
        {
            string sql = @"INSERT INTO akun (username, email, nama, password) 
                           VALUES (@username, @email, @nama, @password)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@nama", user.Nama);
                cmd.Parameters.AddWithValue("@password", user.Password);

                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch
                {
                    // Handle exception or log error
                    return 0;
                }
            }
        }

        public int AuthenticateUser(string username, string password)
        {
            string sql = @"SELECT COUNT(*) FROM akun WHERE username = @username AND password = @password";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
                catch
                {
                    // Handle exception or log error
                    return 0;
                }
            }
        }

        public string ShowPassword(string email)
        {
            string password = null;

            string sql = @"SELECT password FROM akun WHERE email = @Email";

            using (SQLiteCommand command = new SQLiteCommand(sql, _conn))
            {
                command.Parameters.AddWithValue("@Email", email);

                try
                {
                    password = command.ExecuteScalar() as string;
                }
                catch
                {
                }
            }

            return password;
        }

        public List<User> ReadAll()
        {
            List<User> users = new List<User>();

            string sql = "SELECT * FROM akun";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                try
                {
                    _conn.Open();
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                Username = reader["username"].ToString(),
                                Email = reader["email"].ToString(),
                                Nama = reader["nama"].ToString(),
                                Password = reader["password"].ToString()
                            };

                            users.Add(user);
                        }
                    }
                }
                catch 
                {
                    // Handle exception or log error
                }
                finally
                {
                    _conn.Close();
                }
            }

            return users;
        }
        public User GetUserByUsername(string username)
        {
            string connectionString = "Data Source=DbBelanjaIn.db";
            string sql = "SELECT * FROM akun WHERE username = @username";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User user = new User
                                {
                                    Username = reader["username"].ToString(),
                                    Email = reader["email"].ToString(),
                                    Nama = reader["nama"].ToString(),
                                    Password = reader["password"].ToString()
                                };

                                return user;
                            }
                        }
                    }
                    catch 
                    {
                        // Handle exception or log error
                    }
                }
            }

            return null; // Mengembalikan null jika tidak menemukan pengguna
        }

    }
}
