namespace BorderControl.Interfaces
{
    public interface IIdentifiable
    {
        string Id { get;}

        bool CheckId(string lastDigit);
    }
}
