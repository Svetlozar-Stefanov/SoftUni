using MortalEngines.Core.Contracts;

namespace MortalEngines.Core.Commands
{
    public class ManufactureTankCommand : ICommand
    {
        public string Execute(MachinesManager machinesManager, params string[] parameters)
        {
            string name = parameters[0];
            double attack = double.Parse(parameters[1]);
            double defense = double.Parse(parameters[2]);

            return machinesManager.ManufactureTank(name, attack, defense);
        }
    }
}
