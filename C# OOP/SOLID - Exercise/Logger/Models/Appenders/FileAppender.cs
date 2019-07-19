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

        public FileAppender(ILayout layout, IFile file, ReportLevel reportLevel = ReportLevel.INFO)
        {
            Layout = layout;
            File = file;
            ReportLevel = reportLevel;
        }

        public ILayout Layout { get; set; }

        public IFile File { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public void AppendMessage(IMessage message)
        {
            
        }

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString()}, Messages appended: {messagesCount}, File size {File.Size}";
        }
    }
}
