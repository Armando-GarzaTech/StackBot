using System;

namespace GarzaTech.Core.Domain
{
    public interface IInterest
    {
        string Name { get; }
        string Description { get; }
    }


    public class Interest : IInterest
    {
        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();
    }
}
