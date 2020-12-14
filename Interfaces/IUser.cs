
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUser
    {
        public User GetUserDB(string id);
        IEnumerable<User> GetAll();
        User Get(int id);
        User GetUserDB(int value);
    }
}
