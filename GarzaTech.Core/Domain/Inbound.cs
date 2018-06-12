using System;

namespace GarzaTech.Core.Domain
{
    public interface IInbound
    {
        void CreateStation(string stationName);
        void AddTopic(string stationName, string topic);
        void LinkTopic(string topicIdent, string linkedTopicId, bool positive = true);
    }


    public class Inbound : IInbound
    {
        public void AddTopic(string stationName, string topic)
        {
            throw new NotImplementedException();
        }

        public void CreateStation(string stationName)
        {
            throw new NotImplementedException();
        }

        public void LinkTopic(string topicIdent, string linkedTopicId, bool positive = true)
        {
            throw new NotImplementedException();
        }
    }
}
