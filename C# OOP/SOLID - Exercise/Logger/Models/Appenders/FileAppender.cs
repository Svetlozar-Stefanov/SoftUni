using Logger.Contracts;
using Logger.Models.Enums;
using Logger.Models.Files;
using System;
using System.IO;

namespace Logger.Models.Appenders
{
    public class FileAppender : IAppender
    {
        public FileAppender()
        {
            File = new LogFile();
        }
        public FileAppender(ILayout layout, IFile file)
        {
            Layout = layout;
            File = file;
            ReportLevel = ReportLevel.INFO;
        }

        public FileAppender(ILayout layout, IFile file, ReportLevel reportLevel)
        {
            Layout = layout;
            File = file;
            ReportLevel = reportLevel;
        }

        public ILayout Layout { get; set; }

        public IFile File { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public int MessagesCount { get; private set; }

        public void AppendMessage(IMessage message)
        {
            if ((int)ReportLevel <= (int)message.ReportLevel)
            {
                File.Write(message, Layout.MessageFormat);
                MessagesCount++;
            }
        }

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString()}, Messages appended: {MessagesCount}, File size {File.Size}";
        }
    }
}
