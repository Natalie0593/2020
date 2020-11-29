

using BlogHost.Data.Interfaces;
using Entities;
using BlogHost.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogHost.Data.Services
{
    public class VideoService : IVideoService
    {
        private readonly IVideo _video;
        private readonly IPublicationService _publicationService;

        public  VideoService(IVideo video, IPublicationService publicationService)
        {
            _publicationService = publicationService;
            _video = video;
        }

        public async Task<Video> AddVideo(int id, VideoViewModel video)
        {
            var module =_publicationService.GetPostDB(id);

            Video new_video = new Video
            {
               // Id = Guid.NewGuid(),
                Name = video.Name,
                Url = video.Url,
                PublicationId = module.Id,
        };
            await _video.AddVideo(new_video); 
            return new_video;
        }

        public async Task DeleteVideoById(int id)
        {
            await _video.DeleteVideoById(id);
        }

        public async Task<Video> EditVideo(int id, VideoViewModel video)
        {
            Video new_video = await _video.GetVideo(id);

            if (new_video != null)
            {
                new_video.Name = video.Name;
                new_video.Url = video.Url;
                await _video.UpdateVideo(new_video);
            }
            return new_video;
        }

        public async Task<IEnumerable<Video>> GetAllVideos(int id)
        {
            return await _video.GetAllVideos(id);
        }

        public async Task<Video> GetVideo(int id)
        {
            return await _video.GetVideo(id);
        }
    }
}
