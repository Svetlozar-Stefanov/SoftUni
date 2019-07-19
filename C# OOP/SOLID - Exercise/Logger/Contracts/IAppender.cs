using Logger.Models.Enums;

namespace Logger.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; set; }

        ReportLevel ReportLevel { get; set; }

        void AppendMessage(IMessage message);
    }
}
