

using Entities;
using System.Collections.Generic;

namespace BlogHost.Data.Services
{
    public  interface IUserService
    {
        public User GetUserDB(string id);
        public IEnumerable<User> GetAll();
    }
}
