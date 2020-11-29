

using Entities;
using System.Collections.Generic;
using ViewModels;

namespace Services
{
    public interface IPublicationService
    {
        public Publication GetPostDB(int id);
        public IEnumerable<Publication> AllPostIsFavorite();
        public IEnumerable<Publication> AllPost();
        public IEnumerable<Publication> AllThemsPost(int id);
        public IEnumerable<Publication> MyPost(User user);
        public Publication AddPublicationDB(CreatePublicationViewModel model, User user);
        public void UpdatePost(Publication post);
        public Publication GetLikePost(int id);
        public void DeletePost(Publication post);

    }
}
