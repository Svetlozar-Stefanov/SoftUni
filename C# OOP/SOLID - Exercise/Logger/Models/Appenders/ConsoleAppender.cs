using Logger.Contracts;
using Logger.Models.Enums;
using Logger.Models.Layouts;
using System;
using System.Globalization;

namespace Logger.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private int messagesCount = 0;

        public ConsoleAppender()
        {

        }

        public ILayout Layout { get; private set; }

        public ReportLevel ReportLevel { get; private set; }

        public void AppendMessage(IMessage message)
        {
            DateLayout dateLayout = new DateLayout();

            Console.WriteLine(string.Format(Layout.Format, 
                message.Date.ToString(dateLayout.Format,CultureInfo.InvariantCulture), 
                message.ReportLevel, message.Message));

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
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}, Report level: {ReportLevel.ToString()}, Messages appended: {messagesCount}";
        }
    }
}
