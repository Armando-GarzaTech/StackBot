using System;

namespace GarzaTech.Core.Domain
{
    public interface IMember
    {
        string Email { get; }
        string DisplayName { get; }
        IInterest[] Interests { get; }
    }


    public class Member : IMember
    {
        public string Email => throw new NotImplementedException();

        public string DisplayName => throw new NotImplementedException();

        public IInterest[] Interests => throw new NotImplementedException();
    }
}
