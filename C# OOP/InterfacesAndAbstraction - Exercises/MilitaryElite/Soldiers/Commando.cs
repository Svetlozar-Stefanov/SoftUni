using System.Collections.Generic;
using System.Linq;
using System.Text;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite.Soldiers
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corp) 
            : base(id, firstName, lastName, salary, corp)
        {
            Missions = new List<Mission>();
        }

        public List<Mission> Missions { get; private set; }

        public void CompleteMission(string mission)
        {
            Missions.FirstOrDefault(m => m.Name == mission).Status = "Finished";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Missions:");
            foreach (var mission in Missions)
            {
                sb.AppendLine(mission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
