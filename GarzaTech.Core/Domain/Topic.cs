using System;

namespace GarzaTech.Core.Domain
{
    public interface ITopic
    {
        string Ident { get; }
        string TopicText { get; }
        ITopicLink[] Links { get; }
    }

    public class Topic : ITopic
    {
        public string Ident => throw new NotImplementedException();

        public string TopicText => throw new NotImplementedException();

        public ITopicLink[] Links => throw new NotImplementedException();
    }
}
