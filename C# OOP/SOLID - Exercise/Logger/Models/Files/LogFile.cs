using Logger.Contracts;
using System.IO;
using System.Linq;
using System.Text;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        public StringBuilder StringBuilder { get; private set; } = new StringBuilder();

        public int Size => StringBuilder
            .ToString()
            .Sum(c => (int)c);

        public void Write(IMessage message , string layout)
        {
            StringBuilder.AppendLine(string.Format(layout, message.Date, message.ReportLevel.ToString(), message.Message));
        }
    }
}
