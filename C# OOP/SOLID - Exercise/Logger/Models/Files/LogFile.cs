using Logger.Contracts;
using Logger.Models.IOManagement;
using Logger.Models.Layouts;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        private string currentPath;
        private IIOManager iOManager;

        public LogFile(string currentDirectory = "logs", string currentFile = "log.txt")
        {
            iOManager = new IOManager(currentDirectory, currentFile);

            currentPath = iOManager.CurrentFilePath;
            iOManager.EnsureDirectoryAndFileExistance();
        }

        public ulong Size => GetFileSize();

        private ulong GetFileSize()
        {
            string text = File.ReadAllText(Path);

            char[] elements = text.ToCharArray();

            ulong sum = (ulong)elements.Where(c => char.IsLetter(c)).Sum(c => (int)c);

            return sum;
        }

        public string Path => currentPath;

        public string Write(IMessage message , string layout)
        {
            DateLayout dateLayout = new DateLayout();

            string formattedMessage = string.Format(layout,
                message.Date.ToString(dateLayout.Format, CultureInfo.InvariantCulture),
                message.ReportLevel.ToString(),
                message);

            return formattedMessage;
        }
    }
}
