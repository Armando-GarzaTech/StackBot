namespace GarzaTech.Core.Queries
{
    public class StackResponse
    {
        public Question[] items { get; set; }
    }


    public class Question
    {
        public long question_id { get; set; }
        public string title { get; set; }
        public string[] tags { get; set; }
        public string link { get; set; }
    }
    
}
