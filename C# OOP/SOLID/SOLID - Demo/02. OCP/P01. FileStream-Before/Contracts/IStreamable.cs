namespace P01._FileStream_Before.Contracts
{
    public interface IStreamable
    {
        int Length { get; }

        int Sent { get; }
    }
}
