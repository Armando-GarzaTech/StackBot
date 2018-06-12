namespace GarzaTech.Core.Queries
{
    public class GitResponse
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public GitItem[] items { get; set; }
    }

    public class GitItem
    {
        public string name { get; set; }
        public string html_url { get; set; }
        public string url { get; set; }
    }
}
