using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;
        public string Name { get; set; }
        public int Count
        {
            get
            {
                return gladiators.Count;
            }
        }

        public Arena(string v)
        {
            Name = v;
            gladiators = new List<Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator gladiator = gladiators.Where(g => g.Name == name).FirstOrDefault();
            gladiators.Remove(gladiator);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return gladiators.OrderByDescending(g => g.GetStatPower()).FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return gladiators.OrderByDescending(g => g.GetWeaponPower()).FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return gladiators.OrderByDescending(g => g.GetTotalPower()).FirstOrDefault();
        }

        public override string ToString()
        {
            return $"{Name} - {Count} gladiators are participating." + "\n";
        }
    }
}
