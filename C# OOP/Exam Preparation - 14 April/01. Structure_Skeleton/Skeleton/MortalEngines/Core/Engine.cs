using MortalEngines.Core.Contracts;
using MortalEngines.IO;
using MortalEngines.IO.Contracts;
using System.Collections.Generic;

namespace MortalEngines.Core
{
    public class Engine : IEngine
    {
        private IReader reader;

        public Engine()
        {
            reader = new Reader();
        }

        public void Run()
        {
            reader.ReadCommands();
        }
    }
}
