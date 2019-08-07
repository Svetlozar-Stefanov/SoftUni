namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private List<IPilot> pilots;
        private List<ITank> tanks;
        private List<IFighter> fighters;
        private List<IMachine> machines;

        public MachinesManager()
        {
            pilots = new List<IPilot>();
            tanks = new List<ITank>();
            fighters = new List<IFighter>();
            machines = new List<IMachine>();
        }

        public string HirePilot(string name)
        {
            if (pilots.Any(p => p.Name == name))
            {
                return $"Pilot {name} is hired already";
            }

            IPilot pilot = new Pilot(name);

            pilots.Add(pilot);

            return $"Pilot {name} hired";
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (tanks.Any(m => m.Name == name))
            {
                return $"Machine {name} is manufactured already";
            }

            ITank tank = new Tank(name, attackPoints, defensePoints);

            tanks.Add(tank);
            machines.Add(tank);

            return $"Tank {name} manufactured - attack: {tank.AttackPoints:f2}; defense: {tank.DefensePoints:f2}";
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (fighters.Any(m => m.Name == name))
            {
                return $"Machine {name} is manufactured already";
            }

            IFighter fighter = new Fighter(name, attackPoints, defensePoints);

            fighters.Add(fighter);
            machines.Add(fighter);

            return $"Fighter {name} manufactured - attack: {fighter.AttackPoints:f2}; defense: {fighter.DefensePoints:f2}; aggressive: ON";
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if (!pilots.Any(p => p.Name == selectedPilotName))
            {
                return $"Pilot {selectedPilotName} could not be found";
            }
            if (!machines.Any(m => m.Name == selectedMachineName))
            {
                return $"Machine {selectedMachineName} could not be found";
            }
            if (machines.Any(m => m.Name == selectedMachineName && m.Pilot != null))
            {
                return $"Machine {selectedMachineName} is already occupied";
            }

            IPilot pilot = pilots.FirstOrDefault(p => p.Name == selectedPilotName);
            IMachine machine = machines.FirstOrDefault(m => m.Name == selectedMachineName);

            pilot.AddMachine(machine);
            machine.Pilot = pilot;

            return $"Pilot {selectedPilotName} engaged machine {selectedMachineName}";
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            if (!machines.Any(m => m.Name == attackingMachineName))
            {
                return $"Machine {attackingMachineName} could not be found";
            }

            if (!machines.Any(m => m.Name == defendingMachineName))
            {
                return $"Machine {defendingMachineName} could not be found";
            }

            IMachine attackingMachine = machines.FirstOrDefault(m => m.Name == attackingMachineName);
            IMachine defendingMachine = machines.FirstOrDefault(m => m.Name == defendingMachineName);

            if (attackingMachine.HealthPoints <= 0)
            {
                return $"Dead machine {attackingMachine.Name} cannot attack or be attacked";
            }

            if (defendingMachine.HealthPoints <= 0)
            {
                return $"Dead machine {defendingMachine.Name} cannot attack or be attacked";
            }

            attackingMachine.Attack(defendingMachine);
            return $"Machine {defendingMachine.Name} was attacked by machine {attackingMachine.Name} - current health: {defendingMachine.HealthPoints:f2}";
        }

        public string PilotReport(string pilotReporting)
        {
            return pilots.FirstOrDefault(p => p.Name == pilotReporting).Report();
        }

        public string MachineReport(string machineName)
        {
            return machines.FirstOrDefault(m => m.Name == machineName).ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (!fighters.Any(f => f.Name == fighterName))
            {
                return $"Machine {fighterName} could not be found";
            }

            fighters.FirstOrDefault(f => f.Name == fighterName).ToggleAggressiveMode();

            return $"Fighter {fighterName} toggled aggressive mode";
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            if (!tanks.Any(m => m.Name == tankName))
            {
                return $"Machine {tankName} could not be found";
            }

            tanks.FirstOrDefault(t => t.Name == tankName).ToggleDefenseMode();

            return $"Tank {tankName} toggled defense mode";
        }
    }
}