namespace P02._Identity_Before.Contracts
{
    public interface IUserChangable
    {
        void Register(string username, string password);

        void Login(string username, string password);
    }
}