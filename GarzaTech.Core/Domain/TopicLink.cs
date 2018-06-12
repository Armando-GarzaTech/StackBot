namespace GarzaTech.Core.Domain
{
    public interface ITopicLink
    {
        string LinkedTopicIdent { get; }
        int Positive { get; }
        int Negitive { get; }
    }

    public class TopicLink : ITopicLink
    {
        public string LinkedTopicIdent => throw new global::System.NotImplementedException();

        public int Positive => throw new global::System.NotImplementedException();

        public int Negitive => throw new global::System.NotImplementedException();
    }
}
