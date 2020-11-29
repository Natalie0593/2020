using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IComment
    {
        public void AddCommentDB(Comment comment);
        public IEnumerable<Comment> AllComments(int id);
        public void DeleteComment(Comment comment);
        public Comment GetCommentDB(int id);
        public void UpdateComment(Comment comment);
    }
}
