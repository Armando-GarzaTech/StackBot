using System.Threading.Tasks;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Core.Extensions;
using Microsoft.Bot.Schema;
using GarzaTech.Core.Queries;

namespace StackBot
{
    public class SearchBot : IBot
    {

        public async Task OnTurn(ITurnContext context)
        {
            if (context.Activity.Type == ActivityTypes.Message)
            {
                var state = context.GetConversationState<SearchState>();

                var processor = new QueryProcessor();

                var text = await processor.Execute(context.Activity.Text);

                await context.SendActivity($"### Found the following:\r\n{text}");
            }
        }
    }    
}
