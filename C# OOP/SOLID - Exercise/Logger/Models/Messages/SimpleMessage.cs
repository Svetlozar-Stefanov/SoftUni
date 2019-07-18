using Logger.Contracts;
using Logger.Models.Enums;

namespace Logger.Models.Messages
{
    public class SimpleMessage : IMessage
    {
        public SimpleMessage(string date, ReportLevel reportLevel, string message)
        {
            Date = date;
            ReportLevel = reportLevel;
            Message = message;
        }

        public string Date { get; private set; }

        public ReportLevel ReportLevel { get; private set; }

        public string Message { get; private set; }
    }
}
