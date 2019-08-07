using MortalEngines.Entities.Contracts;
using System.Text;

namespace MortalEngines.Entities
{
    public class Fighter : BaseMachine, IFighter
    {
        private const double INITIAL_HEALTHPOINTS = 200;

        public Fighter(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, INITIAL_HEALTHPOINTS)
        {
            AggressiveMode = true;
            AttackPoints += 50;
            DefensePoints -= 25;
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (AggressiveMode == true)
            {
                AggressiveMode = false;

                AttackPoints -= 50;
                DefensePoints += 25;
            }
            else if(AggressiveMode == false)
            {
                AggressiveMode = true;

                AttackPoints += 50;
                DefensePoints -= 25;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            if (AggressiveMode)
            {
                sb.AppendLine($" *Aggressive: ON");
            }
            else
            {
                sb.AppendLine($" *Aggressive: OFF");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
