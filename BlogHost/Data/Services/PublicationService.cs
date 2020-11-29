

using BlogHost.Data.Interfaces;
using Entities;
using BlogHost.ViewModels;
using System.Collections.Generic;
using System.IO;

namespace BlogHost.Data.Services
{
    public class PublicationService: IPublicationService
    {
        private readonly IPublication _publication;
        private readonly IUser _user;
        private readonly ITopicService _topic;

        public PublicationService(IPublication publication, IUser user, ITopicService topic)
        {
            _publication = publication;
            _user = user;
            _topic = topic;
        }

        public Publication GetPostDB(int id)
        {
            return _publication.GetPostDB(id);
        }

        public IEnumerable<Publication> AllPostIsFavorite()
        {
            return _publication.AllPostIsFavorite();
        }

        public IEnumerable<Publication> AllPost()
        {
            return _publication.AllPost();
        }

        public IEnumerable<Publication> AllThemsPost(int id)
        {
            return _publication.AllThemsPost(id);
        }

        public IEnumerable<Publication> MyPost(User user)
        {
            return _publication.MyPost(user);
        }


        //private readonly Microsoft.AspNetCore.Identity.UserManager<User> _userManager;

      

        public Publication AddPublicationDB(CreatePublicationViewModel model,User user)
        {
            byte[] imageData = null;
             byte[] imageData2 = null;
            using (var binaryReader = new BinaryReader(model.AvatarPost.OpenReadStream()))
            {
                imageData = binaryReader.ReadBytes((int)model.AvatarPost.Length);
            }
            using (var binaryReader = new BinaryReader(model.AvatarPost2.OpenReadStream()))
            {
                imageData2 = binaryReader.ReadBytes((int)model.AvatarPost2.Length);
            }

            var topic = _topic.GetTopicDB(model.TopicName);


            Publication publ = new Publication
            {
                PublicationName = model.PublicationName,
                Discription = model.Discription,
                PublicationText = model.PublicationText,
                AvatarPost = imageData,
                AvatarPost2 = imageData2,
                isFavorite = model.isFavorite,
                TopicId = topic.Id,
                Topic = topic, //_topic.GetTopicDB(model.TopicName),
                User = user,
            };
            publ.LikePost = 0;
            _publication.AddPublicationDB(publ);
            return (publ);
        }

        public void UpdatePost(Publication post) => _publication.UpdatePost(post);

        public Publication GetLikePost(int id)
        {
            return _publication.GetLikePost(id);
        }

        public void DeletePost(Publication post) => _publication.DeletePost(post);
    }

}
