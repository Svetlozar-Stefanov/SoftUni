using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite.Soldiers
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corp) 
            : base(id, firstName, lastName, salary, corp)
        {
            Repairs = new List<Repair>();
        }

        public List<Repair> Repairs { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Repairs:");
            foreach (var repair in Repairs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
