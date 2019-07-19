using Logger.Contracts;
using Logger.Models.IOManagement;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        private string currentPath;
        private IIOManager iOManager;

        public LogFile(string currentDirectory = "\\logs\\", string currentFile = "log.txt")
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

        ulong IFile.Size => throw new System.NotImplementedException();

        public void Write(IMessage message , string layout)
        {
            
        }
    }
}
