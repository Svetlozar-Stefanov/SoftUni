using System;
using System.Collections.Generic;
using Logger.Contracts;
using Logger.Core;
using Logger.Core.Factories;

namespace Logger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ILogger logger = GetLogger();

            Engine engine = new Engine(logger);
            engine.Run();
        }

        private static ILogger GetLogger()
        {
            List<IAppender> appenders = new List<IAppender>();

            int appendersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appendersCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string appenderType = input[0];
                string layoutType = input[1];

                LayoutFactory layoutFactory = new LayoutFactory();
                ILayout layout = layoutFactory.GetLayout(layoutType);

                AppenderFactory appenderFactory = new AppenderFactory();
                if (input.Length == 3)
                {
                    string reportLevel = input[2];

                    appenders.Add(appenderFactory.GetAppender(appenderType, layout, reportLevel));
                }
                else
                {
                    appenders.Add(appenderFactory.GetAppender(appenderType, layout));
                }
            }

            return new Models.Loggers.Logger(appenders);
        }
    }
}
