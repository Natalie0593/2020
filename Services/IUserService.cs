

using Entities;
using System.Collections.Generic;

namespace Services
{
    public  interface IUserService
    {
        public User GetUserDB(string id);
        public IEnumerable<User> GetAll();
    }
}
