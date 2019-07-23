using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string postfix = "Command";

        public string Read(string args)
        {
            string[] info = args
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string inputType = info[0] + postfix;

            Type type = typeof(CommandInterpreter)
                .Assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name == inputType);

            if (type == null)
            {
                throw new ArgumentException("Invalid input!");
            }

            var instance = Activator.CreateInstance(type);

            ICommand command = (ICommand)instance;

            string[] parameters = info.Skip(1).ToArray();

            string result = command.Execute(parameters);


            return result;
        }
    }
}
