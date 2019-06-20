using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public string  Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public int GetTotalPower()
        {
            return GetWeaponPower() + GetStatPower();
        }

        public int GetWeaponPower()
        {
            int sum = Weapon.Size + Weapon.Solidity + Weapon.Sharpness;
            return sum;
        }

        public int GetStatPower()
        {
            int sum = Stat.Skills + Stat.Strength + Stat.Intelligence + Stat.Flexibility + Stat.Agility;
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} - {GetTotalPower()}");
            sb.AppendLine($"  Weapon Power: {GetWeaponPower()}");
            sb.AppendLine($"  Stat Power: {GetStatPower()}");

            return sb.ToString();
        }
    }
}
