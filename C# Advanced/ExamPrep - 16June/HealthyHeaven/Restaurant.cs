using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Restaurant
    {
        public List<Salad> salads { get; set; }

        public string Name { get; set; }

        public Restaurant(string name)
        {
            Name = name;
            salads = new List<Salad>();
        }

        public void Add(Salad salad)
        {
            salads.Add(salad);
        }

        public bool Buy(string name)
        {
            return salads.Remove(salads.Where(s => s.Name == name).FirstOrDefault());
        }

        public Salad GetHealthiestSalad()
        {
            return salads.OrderBy(s => s.GetTotalCalories()).FirstOrDefault();
        }

        public string GenerateMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} have {salads.Count} salads:");
            foreach (var salad in salads)
            {
                sb.AppendLine(salad.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
