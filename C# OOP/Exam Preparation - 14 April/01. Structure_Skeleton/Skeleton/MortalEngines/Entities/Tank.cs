using MortalEngines.Entities.Contracts;
using System.Text;

namespace MortalEngines.Entities
{
    public class Tank : BaseMachine, ITank
    {
        private const double INITIAL_HEALTHPOINTS = 100;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, INITIAL_HEALTHPOINTS)
        {
            DefenseMode = true;
            AttackPoints -= 40;
            DefensePoints += 30;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (DefenseMode == true)
            {
                DefenseMode = false;

                AttackPoints += 40;
                DefensePoints -= 30;
            }
            else if (DefenseMode == false)
            {
                DefenseMode = true;

                AttackPoints -= 40;
                DefensePoints += 30;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            if (DefenseMode)
            {
                sb.AppendLine($" *Defense: ON");
            }
            else
            {
                sb.AppendLine($" *Defense: OFF");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
