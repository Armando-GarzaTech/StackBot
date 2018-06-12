using GarzaTech.Core.System;

namespace GarzaTech.Core.Queries
{
    public class LuisQuery : WebQueryBase<LuisResponse>
    {
        public LuisQuery(string api) : base(api)
        {
        }
    }
}
