using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Stat
    {
        public int Strength { get; set; }
        public int Flexibility { get; set; }
        public int Agility { get; set; }
        public int Skills { get; set; }
        public int Intelligence { get; set; }

        public Stat(int str, int flex, int agil, int skills, int intelli)
        {
            Strength = str;
            Flexibility = flex;
            Agility = agil;
            Skills = skills;
            Intelligence = intelli;
        }
    }
}
