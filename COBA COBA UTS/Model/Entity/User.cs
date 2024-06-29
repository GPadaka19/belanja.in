namespace COBA_COBA_UTS.Model.Entity
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Nama { get; set; }
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; } // Adding the IsLoggedIn property
    }
}
