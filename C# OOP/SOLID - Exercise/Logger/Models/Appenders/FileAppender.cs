using Logger.Contracts;
using Logger.Models.Enums;
using Logger.Models.Files;
using System;
using System.IO;

namespace Logger.Models.Appenders
{
    public class FileAppender : IAppender
    {
        private int messagesCount = 0;

        public FileAppender()
        {
            FileType = new LogFile();
        }

        public ILayout Layout { get;private set; }

        public IFile FileType { get; private set; }

        public ReportLevel ReportLevel { get; private set; }

        public void AppendMessage(IMessage message)
        {
            File.AppendAllText(FileType.Path, FileType.Write(message, Layout.Format) + Environment.NewLine);
            messagesCount++;
        }

        public void SetLayout(ILayout layout)
        {
            Layout = layout;
        }

        public void SetReportLevel(ReportLevel reportLevel)
        {
            ReportLevel = reportLevel;
        }

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString()}, Messages appended: {messagesCount}, File size {FileType.Size}";
        }
    }
}
