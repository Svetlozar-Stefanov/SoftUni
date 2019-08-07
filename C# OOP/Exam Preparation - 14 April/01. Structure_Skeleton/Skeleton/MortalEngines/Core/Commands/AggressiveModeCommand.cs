using MortalEngines.Core.Contracts;

namespace MortalEngines.Core.Commands
{
    public class AggressiveModeCommand : ICommand
    {
        public string Execute(MachinesManager machinesManager, params string[] parameters)
        {
            string name = parameters[0];

            return machinesManager.ToggleFighterAggressiveMode(name);
        }
    }
}
