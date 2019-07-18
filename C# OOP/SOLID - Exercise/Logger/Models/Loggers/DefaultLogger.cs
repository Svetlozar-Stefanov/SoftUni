using System.Collections.Generic;
using Logger.Contracts;
using Logger.Models.Messages;

namespace Logger.Models.Loggers
{
    public class DefaultLogger : ILogger
    {
        public DefaultLogger()
        {
            Appenders = new List<IAppender>();
        }
        public DefaultLogger(List<IAppender> appenders)
        {
            Appenders = appenders;
        }

        public List<IAppender> Appenders { get; private set; }

        public void AddAppender(IAppender appender)
        {
            Appenders.Add(appender);
        }

        public void Critical(string date, string message)
        {
            IMessage info = new SimpleMessage(date, Enums.ReportLevel.CRITICAL, message);
            Log(info);
        }

        public void Error(string date, string message)
        {
            IMessage info = new SimpleMessage(date, Enums.ReportLevel.ERROR, message);
            Log(info);
        }

        public void Fatal(string date, string message)
        {
            IMessage info = new SimpleMessage(date, Enums.ReportLevel.FATAL, message);
            Log(info);
        }

        public void Info(string date, string message)
        {
            IMessage info = new SimpleMessage(date, Enums.ReportLevel.INFO, message);
            Log(info);
        }

        public void Warning(string date, string message)
        {
            IMessage info = new SimpleMessage(date, Enums.ReportLevel.WARNING, message);
            Log(info);
        }

        private void Log(IMessage message)
        {
            foreach (var appender in Appenders)
            {
                appender.AppendMessage(message);
            }
        }
    }
}
