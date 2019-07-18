using Logger.Models.Enums;

namespace Logger.Contracts
{
    public interface IMessage
    {
        string Date { get; }

        ReportLevel ReportLevel { get; }

        string Message { get; }
    }
}
