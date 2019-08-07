using MortalEngines.Core.Contracts;

namespace MortalEngines.Core.Commands
{
    public class AttackCommand : ICommand
    {
        public string Execute(MachinesManager machinesManager, params string[] parameters)
        {
            string name1 = parameters[0];
            string name2 = parameters[1];

            return machinesManager.AttackMachines(name1, name2);
        }
    }
}
