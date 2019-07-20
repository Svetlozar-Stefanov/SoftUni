using Logger.Models.Enums;

namespace Logger.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; }

        void AppendMessage(IMessage message);

        void SetLayout(ILayout layout);

        void SetReportLevel(ReportLevel reportLevel);
    }
}
