using Logger.Models.Enums;

namespace Logger.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; set; }

        ReportLevel ReportLevel { get; set; }

        int MessagesCount { get; }

        void AppendMessage(IMessage message);
    }
}
