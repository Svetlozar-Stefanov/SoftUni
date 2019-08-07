using MortalEngines.Core.Contracts;

namespace MortalEngines.Core.Commands
{
    public class ManufactureFighterCommand : ICommand
    {
        public string Execute(MachinesManager machinesManager, params string[] parameters)
        {
            string name = parameters[0];
            double attack = double.Parse(parameters[1]);
            double defense = double.Parse(parameters[2]);

            return machinesManager.ManufactureFighter(name, attack, defense);
        }
    }
}
