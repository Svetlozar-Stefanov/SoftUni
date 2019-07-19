using System;

using Logger.Models.Enums;

namespace Logger.Contracts
{
    public interface IMessage
    {
        DateTime Date { get; }

        ReportLevel ReportLevel { get; }

        string Message { get; }
    }
}
