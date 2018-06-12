using GarzaTech.Core.System;
using System.Linq;
using System.Threading.Tasks;

namespace GarzaTech.Core.Queries
{
    public class QueryProcessor
    {
        private IRuntimeSettings _settings;

        public QueryProcessor(IRuntimeSettings settings = null)
        {
            _settings = (settings ?? RuntimeSettings.Instance);
        }

        public async Task<string> Execute(string text)
        {
            var topics = await QueryLuis(text);

            var table = new TableProducer();

            var stackQuery = new StackQuery(_settings.StackApi);
            var stackResponse = await stackQuery.Call(topics);
            foreach (var question in stackResponse.items)
            {
                table.Append(TableProducer.SourceType.Stackoverflow,
                    question.title,
                    question.link);
            }

            //var gitQuery = new GitQuery(_settings.GitApi);
            //var result = await gitQuery.Call(topics);
            //foreach (var project in result.items.Take(5))
            //{
            //    table.Append(TableProducer.SourceType.GitHub,
            //        project.name,
            //        project.html_url);
            //}


            return table.ToString(); 
        }

        private async Task<string> QueryLuis(string text)
        {
            var query = new LuisQuery(_settings.LuisApi);
            var results = await query.Call(text);

            var list = (from t in results.entities
                       select t.entity);

            return string.Join("&", list);
        }       

    }
}
