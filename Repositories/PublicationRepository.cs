using Entities;
using Interfaces;
using Services;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public class PublicationRepository : IPublication
    {
        private readonly AppDBContext _appDbContext;

        public PublicationRepository(AppDBContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public void AddPublicationDB(Publication publ)
        {
            _appDbContext.Publications.Add(publ);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Publication> AllPost()
        {
            return _appDbContext.Publications.ToList();
        }

        public IEnumerable<Publication> AllPostIsFavorite()
        {
            return _appDbContext.Publications.Where(x => x.isFavorite == true).ToList();
        }


        public IEnumerable<Publication> AllThemsPost(int idTopic)
        {
            return _appDbContext.Publications.Where(x => x.TopicId == idTopic).ToList();
        }

        public IEnumerable<Publication> MyPost(User user)
        {
            return _appDbContext.Publications.Where(x => x.User.Id == user.Id).ToList();
        }

        public Publication GetPostDB(int id)
        {
            return _appDbContext.Publications.Where(x => x.Id == id).FirstOrDefault();
        }

        public void UpdatePost(Publication post)
        {
            _appDbContext.Publications.Update(post);
            _appDbContext.SaveChanges();
        }

        public void DeletePost(Publication post)
        {
            _appDbContext.Publications.Remove(post);
            _appDbContext.SaveChanges();
        }

        public Publication GetLikePost(int id)
        {
            Publication update = _appDbContext.Publications.ToList().Find(u => u.Id == id);
            update.LikePost += 1;
            _appDbContext.SaveChanges();

            return update;

        }
    }
}
