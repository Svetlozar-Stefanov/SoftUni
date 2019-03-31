using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flour = false;
            bool eggs = false;
            bool sugar = false;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                 
                string input = Console.ReadLine();
                while (input != "Bake!")
                {
                    if (input == "flour")
                    {
                        flour = true;
                    }
                    if (input == "eggs")
                    {
                        eggs = true;
                    }
                    if (input == "sugar")
                    {
                        sugar = true;
                    }
                    input = Console.ReadLine();
                }
                if (eggs && flour && sugar == true)
                {
                    Console.WriteLine($"Baking batch number {i}...");
                    flour = false;
                    eggs = false;
                    sugar = false;
                }
                else
                {
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                    i--;
                }


            }



        }
    }
}
