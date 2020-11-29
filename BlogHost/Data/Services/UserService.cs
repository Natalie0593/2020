

using BlogHost.Data.Interfaces;
using Entities;
using System.Collections.Generic;

namespace BlogHost.Data.Services
{
    public class UserService: IUserService
    {
        
        IUser _user;
        public UserService(IUser user)
        {
            _user = user;
        }
        public User GetUserDB(string id)
        {
            return _user.GetUserDB(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _user.GetAll();
        }


    }
}
