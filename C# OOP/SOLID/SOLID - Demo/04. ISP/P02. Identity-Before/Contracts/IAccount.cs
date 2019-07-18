namespace P02._Identity_Before.Contracts
{
    using System.Collections.Generic;

    public interface IAccount : IPasswordChangable, IUserChangable, IStatisticable
    {
        
    }
}
