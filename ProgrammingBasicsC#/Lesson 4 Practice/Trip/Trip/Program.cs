using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine();

            string region = string.Empty;
            string stayingPlace = string.Empty;

            if (budget <= 100)
            {
                region = "Bulgaria";
                if (seasson == "summer")
                {
                    stayingPlace = "Camp";
                    budget = budget * 0.3;
                }
                else
                {
                    stayingPlace = "Hotel";
                    budget = budget * 0.7;
                }

            }
            else if (budget <= 1000)
            {
                region = "Balkans";
                if (seasson == "summer")
                {
                    stayingPlace = "Camp";
                    budget = budget * 0.4;
                }
                else
                {
                    stayingPlace = "Hotel";
                    budget = budget * 0.8;
                }               
            }
            else
            {
                region = "Europe";
                stayingPlace = "Hotel";
                budget = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {region}");
            Console.WriteLine($"{stayingPlace} - {budget:f2}");
        }
    }
}
