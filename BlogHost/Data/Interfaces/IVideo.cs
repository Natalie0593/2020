
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogHost.Data.Interfaces
{
    public interface IVideo
    {
        Task AddVideo(Video video);
        Task<IEnumerable<Video>> GetAllVideos(int id);
        Task DeleteVideo(Video video);
        Task DeleteVideoById(int id);
        Task<Video> GetVideo(int id);
        Task UpdateVideo(Video video);

    }
}
