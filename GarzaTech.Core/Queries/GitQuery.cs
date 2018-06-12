using GarzaTech.Core.System;

namespace GarzaTech.Core.Queries
{
    public class GitQuery : WebQueryBase<GitResponse>
    {
        public GitQuery(string api) : base(api)
        {
        }
    }
}
