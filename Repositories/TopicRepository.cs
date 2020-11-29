using Entities;
using Interfaces;
using Services;
using System.Linq;

namespace Repositories
{
    public class TopicRepository : ITopic
    {
        private readonly AppDBContext _appDbContext;

        public TopicRepository(AppDBContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public int GetIDTopicDB(string nameTopic)
        {
            return _appDbContext.Topics.FirstOrDefault(x => x.NameTopic == nameTopic).Id;
        }

        public Topic GetTopicDB(string nameTopic)
        {
            return _appDbContext.Topics.FirstOrDefault(x => x.NameTopic == nameTopic);
        }
        public string GetTopicName(int Id)
        {
            return _appDbContext.Topics.FirstOrDefault(x => x.Id == Id).NameTopic;
        }

    }
}
