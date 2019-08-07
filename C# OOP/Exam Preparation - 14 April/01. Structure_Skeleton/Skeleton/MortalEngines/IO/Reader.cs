using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MortalEngines.Core;
using MortalEngines.Core.Contracts;
using MortalEngines.IO.Contracts;

namespace MortalEngines.IO
{
    public class Reader : IReader
    {
        private IWriter writer = new Writer();
        private MachinesManager machinesManager = new MachinesManager();

        public IList<ICommand> ReadCommands()
        {
            List<ICommand> commands = new List<ICommand>();

            string input = Console.ReadLine();

            while (input != "Quit")
            {
                string[] parameters = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parameters[0] + "Command";

                string[] info = parameters.Skip(1).ToArray();

                Assembly assembly = Assembly.GetExecutingAssembly();

                Type commandType = assembly
                    .GetTypes().FirstOrDefault(t => t.Name == command);

                var instance = (ICommand)Activator.CreateInstance(commandType);

                if (commandType != null)
                {
                    commands.Add((ICommand)Activator.CreateInstance(commandType));
                    writer.Write(instance.Execute(machinesManager, info));
                }

                input = Console.ReadLine();
            }

            return commands;
        }
    }
}
