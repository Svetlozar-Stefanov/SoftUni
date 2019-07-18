using Logger.Contracts;
using Logger.Models.Enums;
using System;

namespace Logger.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender()
        {

        }
        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
            ReportLevel = ReportLevel.INFO;
        }

        public ConsoleAppender(ILayout layout, ReportLevel reportLevel)
            : this(layout)
        {
            ReportLevel = reportLevel;
        }

        public ILayout Layout { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public int MessagesCount { get; private set; }

        public void AppendMessage(IMessage message)
        {
            if ((int)ReportLevel <= (int)message.ReportLevel)
            {
                Console.WriteLine(string.Format(Layout.MessageFormat, message.Date, message.ReportLevel, message.Message));
                MessagesCount++;
            }
        }

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString()}, Messages appended: {MessagesCount}";
        }
    }
}
