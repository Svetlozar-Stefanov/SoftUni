namespace MortalEngines.Core.Contracts
{
    public interface ICommand
    {
        string Execute(MachinesManager machinesManager, params string[] parameters);
    }
}
