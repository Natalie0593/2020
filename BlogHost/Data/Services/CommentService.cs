

using BlogHost.Data.Interfaces;
using Entities;
using BlogHost.ViewModels;
using System.Collections.Generic;

namespace BlogHost.Data.Services
{
    public class CommentService:ICommentSevice
    {
        IComment _comment;
        //private readonly IPublication _publication; //заменить на сервисы
        IPublicationService _publicationService;
       

        public CommentService(IComment comment, IPublicationService publicationService)
        {
                     
            _comment = comment;
            _publicationService = publicationService;
        }


        //public void Hello(int postId) // передаем id комента
        //{
        //    var com = _comment.AllComments(postId); //айди поста
            
        //    int count = 0;
        //    foreach (var c in com)
        //    {
        //        var likes = _likeService.GetAllLikes(c.Id);
        //        foreach (var item in likes)
        //        {
        //            count += 1;
        //        }
        //        c.polelike = count;

        //    }

        //}


        public Comment CreateComment(CreateCommentViewModel model, int ID, string login)
        {
            Comment comment = new Comment
            {
                CommentText = model.CommentText,
                LoginUser = login,//_user.GetUserDB(_userManager.GetUserId(User)).UserName,
                PublicationID = ID,
                Publication = _publicationService.GetPostDB(ID)
            };

            _comment.AddCommentDB(comment);
            return comment;
        }

        public void DeleteComment(Comment comment)
        {
            _comment.DeleteComment(comment);
        }

        public Comment GetCommentDB(int id)
        {
            return _comment.GetCommentDB(id);
        }
        public Comment EditComment(CreateCommentViewModel model, Comment comment)
        {

            comment.CommentText = model.CommentText;

            _comment.UpdateComment(comment);
            return comment;

        }
        public IEnumerable<Comment> AllComments(int id)
        {
           // Hello(id);
            return _comment.AllComments(id);
        }
    }
}
