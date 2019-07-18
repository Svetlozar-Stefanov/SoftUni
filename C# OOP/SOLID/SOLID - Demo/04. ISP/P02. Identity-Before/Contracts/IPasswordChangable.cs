namespace P02._Identity_Before.Contracts
{
    public interface IPasswordChangable
    {
        bool RequireUniqueEmail { get; }

        int MinRequiredPasswordLength { get; }

        int MaxRequiredPasswordLength { get; }

        void ChangePassword(string oldPass, string newPass);
    }
}