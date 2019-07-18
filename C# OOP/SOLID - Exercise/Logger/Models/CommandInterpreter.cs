using Logger.Contracts;
using Logger.Models.Appenders;
using Logger.Models.Enums;
using Logger.Models.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Logger.Models
{
    public class CommandInterpreter
    {
        private List<ILayout> layouts = new List<ILayout>
        {
            new SimpleLayout(),
            new XmlLayout()
        };

        private List<IAppender> appenders = new List<IAppender>
        {
            new ConsoleAppender(),
            new FileAppender()
        };

        public IAppender GenerateAppender(string input)
        {
            IAppender appender = null;

            string[] info = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string appenderType = info[0];
            string layoutType = info[1];

            ILayout layout = layouts.FirstOrDefault(l => l.GetType().Name.ToLower() == layoutType.ToLower());

            appender = appenders.FirstOrDefault(a => a.GetType().Name.ToLower() == appenderType.ToLower());
            appender.Layout = layout;

            if (info.Length == 3)
            {
                string reportLevel = info[2];
                ReportLevel report = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel);
                appender.ReportLevel = report;
            }

            return appender;
        }
    }
}
