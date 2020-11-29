using BlogHost.Data;
using BlogHost.Data.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogHost.Data.Repositories
{
    public class VideoRepository : IVideo
    {
        private readonly AppDBContext _appDbContext;

        public VideoRepository(AppDBContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task AddVideo(Video video)
        {
            await _appDbContext.Videos.AddAsync(video);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteVideo(Video video)
        {
            _appDbContext.Videos.Remove(video);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteVideoById(int id)
        {
            var video = await _appDbContext.Videos.Where(x => x.Id == id).FirstOrDefaultAsync();
            _appDbContext.Videos.Remove(video);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Video>> GetAllVideos(int id)
        {
            return  await _appDbContext.Videos.Where(_ => _.PublicationId == id).ToListAsync();

        }

        public async Task<Video> GetVideo(int id)
        {
            return await _appDbContext.Videos.Where(x => x.Id == id).Include(v => v.Publication).FirstOrDefaultAsync();
        }

        public async Task UpdateVideo(Video video)
        {
            _appDbContext.Videos.Update(video);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
