
using Entities;
using Interfaces;

namespace Services
{
    public class TopicService : ITopicService
    {
        ITopic _topic;

        public TopicService(ITopic topic)
        {
            _topic = topic;
        }
        public Topic GetTopicDB(string nameTopic)
        {
            return _topic.GetTopicDB(nameTopic);
        }

        public int GetIDTopicDB(string nameTopic)
        {
            return _topic.GetIDTopicDB(nameTopic);
        }

        public string GetTopicName(int Id)
        {
            return _topic.GetTopicName(Id);
        }
    }
}
