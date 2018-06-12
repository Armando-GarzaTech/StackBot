using System.Text;

namespace GarzaTech.Core.System
{
    public class TableProducer
    {
        public enum SourceType
        {
            Stackoverflow,
            GitHub
        }

        private StringBuilder _builder = new StringBuilder();

        public TableProducer()
        {
            Clear();
        }

        public void Clear()
        {
            _builder.Clear();
            _builder.AppendLine("|  |  |");
            _builder.AppendLine("| --- | --- |");
        }

        public void Append(SourceType source, string title, string link)
        {
             _builder.AppendLine($"| {GetIcon(source)} | [{title}]({link}) |");
        }

        private string GetIcon(SourceType sourceType)
        {
            var info = sourceType == SourceType.GitHub ? 
                "GitHub" : 
                "Stack Overflow";
            var src = sourceType == SourceType.GitHub ? 
                "https://assets-cdn.github.com/favicon.ico" :
                "https://cdn.sstatic.net/Sites/stackoverflow/img/favicon.ico?v=4f32ecc8f43d";
            return $"![{info} icon]({src})";
        }

        public override string ToString()
        {
            return _builder.ToString();
        }
    }
}
