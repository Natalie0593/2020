

using Entities;

namespace BlogHost.Data.Interfaces
{
    public interface ITopic
    {
        public Topic GetTopicDB(string nameTopic);
        public int GetIDTopicDB(string nameTopic);
        public string GetTopicName(int Id);
    }
}
