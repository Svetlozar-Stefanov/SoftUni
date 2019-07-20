using System.Text;

namespace Logger.Contracts
{
    public interface IFile
    {
        string Path { get; }

        ulong Size { get; }

        string Write(IMessage message, string layout);
    }
}
