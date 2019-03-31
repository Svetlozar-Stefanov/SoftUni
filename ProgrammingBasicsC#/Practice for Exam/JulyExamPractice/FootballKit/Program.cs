using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tShirt = double.Parse(Console.ReadLine());
            double prizeRequirement = double.Parse(Console.ReadLine());

            double shorts = tShirt * 0.75;
            double socks = shorts * 0.2;
            double shoes = (tShirt + shorts) * 2;

            double sum = tShirt + shorts + socks + shoes;
            double afterDiscoutSum = sum - (sum * 0.15);

            if (afterDiscoutSum >= prizeRequirement)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {afterDiscoutSum:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(prizeRequirement - afterDiscoutSum):f2} lv. more.");
            }
        }
    }
}
