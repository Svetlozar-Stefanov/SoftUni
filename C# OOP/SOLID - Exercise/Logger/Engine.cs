using Logger.Contracts;
using Logger.Models;
using Logger.Models.Loggers;
using System;
using System.Reflection;

namespace Logger
{
    public class Engine
    {
        private ILogger logger;

        private CommandInterpreter commandInterpreter = new CommandInterpreter();

        public Engine()
        {
            logger = new DefaultLogger();
        }

        public Engine(ILogger logger)
        {
            this.logger = logger;
        }

        public void Run()
        {
            int appendersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appendersCount; i++)
            {
                string input = Console.ReadLine();

                logger.AddAppender(commandInterpreter.GenerateAppender(input));
            }

            string[] command = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            while (command[0].ToLower() != "end")
            {
                LogData(command);

                command = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);
            }

            PrintAppenders();
        }

        private void PrintAppenders()
        {
            Console.WriteLine("Logger info");
            foreach (var appender in logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }

        private void LogData(string[] command)
        {
            string reportLevel = command[0].ToLower();
            string date = command[1];
            string message = command[2];

            if (reportLevel == "info")
            {
                logger.Info(date, message);
            }
            if (reportLevel == "warning")
            {
                logger.Warning(date, message);
            }
            if (reportLevel == "error")
            {
                logger.Error(date, message);
            }
            if (reportLevel == "critical")
            {
                logger.Critical(date, message);
            }
            if (reportLevel == "fatal")
            {
                logger.Fatal(date, message);
            }
        }
    }
}
