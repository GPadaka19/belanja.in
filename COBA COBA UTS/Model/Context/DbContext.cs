using System;
using System.Data.SQLite;

namespace COBA_COBA_UTS.Model.Context
{
    public class DbContext : IDisposable
    {
        private SQLiteConnection _conn;

        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private SQLiteConnection GetOpenConnection()
        {
            string dbName = @"D:\BERKAS SEMESTER 3\PL\UAS PROGRESS\Keranjang Update NYELL WELL POLL TOTAL HISTORY\COBA COBA UTS\Database\DbBelanjaIn.db";
            string connectionString = $"Data Source={dbName};FailIfMissing=True";

            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();

            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                if (_conn.State != System.Data.ConnectionState.Closed)
                    _conn.Close();

                _conn.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}
