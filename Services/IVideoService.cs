﻿
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViewModels;

namespace Services
{
    public interface IVideoService
    {
        Task<Video> AddVideo(int id, VideoViewModel video);
        Task<Video> EditVideo(int id, VideoViewModel video);
        Task<IEnumerable<Video>> GetAllVideos(int id);
        Task DeleteVideoById(int id);
        Task<Video> GetVideo(int id);
    }
}
