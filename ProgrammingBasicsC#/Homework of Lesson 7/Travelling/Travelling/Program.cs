using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {  
            string command = Console.ReadLine();

            while (command != "End")
            {
                string destination = command;
                double budget = double.Parse(Console.ReadLine());

                while (budget > 0)
                {
                    double saving = double.Parse(Console.ReadLine());
                    budget -= saving;
                }
                Console.WriteLine($"Going to {destination}!");
                command = Console.ReadLine();
            }
            

        }
    }
}
