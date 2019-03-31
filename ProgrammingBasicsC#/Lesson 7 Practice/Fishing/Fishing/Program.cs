using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine());
            int fishCounter = 0;
            int counter = 1;
            double profit = 0;
            double lost = 0;
           
            for (int i = 1; i <= quota; i++)
            {
                double price = 0;
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }
                else
                {
                    fishCounter++;
                    string fish = command;
                    double grams = double.Parse(Console.ReadLine());

                    for (int b = 0; b < fish.Length; b++)
                    {
                        price += (char)fish[b];
                    }
                    price = price / grams;

                    if (counter == 3)
                    {
                        profit += price;
                        counter = 1;
                    }
                    else
                    {
                        lost += price;
                        counter++;
                    }

                }
            }
            if (fishCounter == quota)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }
            if (profit > lost)
            {
                Console.WriteLine($"Lyubo's profit from {fishCounter} fishes is {(profit - lost):f2} leva.");
            }
            else
            {
                Console.WriteLine($"Lyubo lost {(lost - profit):F2} leva today.");
            }

        }
    }
}
