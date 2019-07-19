using System.Text;

namespace Logger.Contracts
{
    public interface IFile
    {
        string Path { get; }

        ulong Size { get; }

        void Write(IMessage message, string layout);
    }
}
