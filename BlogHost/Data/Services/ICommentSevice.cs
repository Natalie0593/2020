

using Entities;
using BlogHost.ViewModels;
using System.Collections.Generic;

namespace BlogHost.Data.Services
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
