using System.Collections.Generic;

namespace P02._Identity_Before.Contracts
{
    public interface IStatisticable
    {
        IEnumerable<IUser> GetAllUsersOnline();

        IEnumerable<IUser> GetAllUsers();

        IUser GetUserByName(string name);
    }
}