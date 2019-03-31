using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Dispanser
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupCapacity = int.Parse(Console.ReadLine());
            int pouredWater = 0;
            int counter = 0;

            while (pouredWater < cupCapacity)
            {
                string button = Console.ReadLine().ToLower();
                if (button == "easy")
                {
                    pouredWater += 50;
                }
                else if (button == "medium")
                {
                    pouredWater += 100;
                }
                else if (button == "hard")
                {
                    pouredWater += 200;
                }
                counter++;
            }

            if (pouredWater == cupCapacity)
            {
                Console.WriteLine($"The dispenser has been tapped {counter} times.");
            }
            else if(pouredWater > cupCapacity)
            {
                Console.WriteLine($"{pouredWater - cupCapacity}ml has been spilled.");
            }
        }
    }
}
