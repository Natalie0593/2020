

using Entities;
using System.Collections.Generic;
using ViewModels;

namespace Services
{
    public interface ICommentSevice
    {
        public Comment CreateComment(CreateCommentViewModel model, int ID, string login);
        public void DeleteComment(Comment comment);
        public Comment GetCommentDB(int id);
        public Comment EditComment(CreateCommentViewModel model, Comment comment);
        public IEnumerable<Comment> AllComments(int id);
        
    }
}
