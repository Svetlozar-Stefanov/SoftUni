using System.Text;

namespace Logger.Contracts
{
    public interface IFile
    {
        StringBuilder StringBuilder { get; }

        int Size { get; }

        void Write(IMessage message, string layout);
    }
}
