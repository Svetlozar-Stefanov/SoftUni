using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Soldiers
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(
            string id,
            string firstName,
            string lastName,
            decimal salary)
            : base (id
                  ,firstName
                  ,lastName
                  ,salary)
        {
            Privates = new List<Private>();
        }

        public List<Private> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var privateSoldier in Privates)
            {
                sb.AppendLine("  " + privateSoldier.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
