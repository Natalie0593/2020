using BlogHost.Data;
using BlogHost.Data.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogHost.Data.Repositories
{
    public class CommentRepository : IComment
    {

        private readonly AppDBContext _appDbContext;
        public CommentRepository(AppDBContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public void AddCommentDB(Comment comment)
        {
            _appDbContext.Comments.Add(comment);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Comment> AllComments(int id)
        {
            return _appDbContext.Comments.Where(_ => _.PublicationID == id).ToList();
        }

        public void DeleteComment(Comment comment)
        {
            _appDbContext.Comments.Remove(comment);
            _appDbContext.SaveChanges();
        }

        public Comment GetCommentDB(int id)
        {
            return _appDbContext.Comments.Where(x => x.Id == id).FirstOrDefault();
        }

        public void UpdateComment(Comment comment)
        {
            _appDbContext.Comments.Update(comment);
            _appDbContext.SaveChanges();
        }
    }
}
