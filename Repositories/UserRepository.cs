using Entities;
using Interfaces;
using Services;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class UserRepository : IUser
    {
        private readonly AppDBContext _appDbContext;

        public UserRepository(AppDBContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public User GetUserDB(string id)
        {
            return _appDbContext.Users.FirstOrDefault(x => x.Id == id.ToString());
        }
        public IEnumerable<User> GetAll()
        {
            return _appDbContext.Users;
        }
        public User Get(int id)
        {
            return _appDbContext.Users.FirstOrDefault(x => x.Id == "id");
        }
    }
}
