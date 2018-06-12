using System;

namespace GarzaTech.Core.Domain
{
    public interface IOutbound
    {
        IInterest Tune(string interestName);
        IInterest[] Find(string[] topics);
    }


    public class Outbound : IOutbound
    {
        public IInterest[] Find(string[] topics)
        {
            throw new NotImplementedException();
        }

        public IInterest Tune(string interestName)
        {
            throw new NotImplementedException();
        }
    }
}
