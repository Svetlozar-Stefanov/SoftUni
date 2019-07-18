using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Contracts
{
    public interface ILogger
    {
        List<IAppender> Appenders { get; }

        void Info(string date, string message);
        void Warning(string date, string message);
        void Error(string date, string message);
        void Critical(string date, string message);
        void Fatal(string date, string message);

        void AddAppender(IAppender appender);
    }
}
