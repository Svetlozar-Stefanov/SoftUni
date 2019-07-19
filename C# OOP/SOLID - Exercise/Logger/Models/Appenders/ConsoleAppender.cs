using Logger.Contracts;
using Logger.Models.Enums;
using System;

namespace Logger.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private int messagesCount = 0;

        public ConsoleAppender(ILayout layout, ReportLevel reportLevel = ReportLevel.INFO)
        {
            Layout = layout;
            ReportLevel = reportLevel;
        }

        public ILayout Layout { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public void AppendMessage(IMessage message)
        {
            Console.WriteLine(string.Format(Layout.Format, message.Date, message.ReportLevel, message.Message));
            messagesCount++;
        }

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString()}, Messages appended: {messagesCount}";
        }
    }
}
