using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int area = l * w;
            string command = Console.ReadLine();

            while (command != "STOP")
            {
                int piecesOfCake = int.Parse(command);
                area -= piecesOfCake;
                if (area < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(area)} pieces more.");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{area} pieces are left.");


        }
    }
}
