using Logger.Contracts;
using Logger.Models.Enums;
using System;

namespace Logger.Models.Messages
{
    public class SimpleMessage : IMessage
    {
        public SimpleMessage(DateTime date, ReportLevel reportLevel, string message)
        {
            Date = date;
            ReportLevel = reportLevel;
            Message = message;
        }

        public DateTime Date { get; private set; }

        public ReportLevel ReportLevel { get; private set; }

        public string Message { get; private set; }
    }
}
