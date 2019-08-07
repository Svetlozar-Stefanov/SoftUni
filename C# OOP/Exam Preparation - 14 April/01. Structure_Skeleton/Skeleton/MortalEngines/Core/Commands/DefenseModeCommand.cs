using MortalEngines.Core.Contracts;

namespace MortalEngines.Core.Commands
{
    public class DefenseModeCommand : ICommand
    {
        public string Execute(MachinesManager machinesManager, params string[] parameters)
        {
            string name = parameters[0];

            return machinesManager.ToggleTankDefenseMode(name);
        }
    }
}
