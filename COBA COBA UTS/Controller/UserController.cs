using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using COBA_COBA_UTS.Model.Repository;
using System.Collections.Generic;
using System.Drawing;

namespace COBA_COBA_UTS.Controller
{
    public class UserController
    {
        private UserRepository _repository;
        public UserController(DbContext context)
        {
            _repository = new UserRepository(context);
        }
        public int Create(User user)
        {
            return _repository.Create(user);
        }

        public int AuthenticateUser(string username, string password)
        {
            return _repository.AuthenticateUser(username, password);
        }

        public string ShowPassword(string email)
        {
            return _repository.ShowPassword(email); // NullReferenceException if _repository is null
                                                    // ...
        }

    }

}
