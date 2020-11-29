
using Entities;

namespace BlogHost.Data.Services
{
    public interface ITopicService
    {
        public Topic GetTopicDB(string nameTopic);
        public int GetIDTopicDB(string nameTopic);
        public string GetTopicName(int Id);
    }
}
