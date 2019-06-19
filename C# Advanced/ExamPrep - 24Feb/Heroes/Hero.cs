using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Item Item { get; set; }

        public Hero(string name, int level, Item item)
        {
            Name = name;
            Level = level;
            Item = item;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Hero: {Name} – {Level}lvl");
            stringBuilder.AppendLine($"Item:");
            stringBuilder.AppendLine($"    * Strength: {Item.Strength}");
            stringBuilder.AppendLine($"    * Ability: {Item.Ability}");
            stringBuilder.AppendLine($"    * Intelligence: {Item.Intelligence}");
            return stringBuilder.ToString();
        }
    }
}
