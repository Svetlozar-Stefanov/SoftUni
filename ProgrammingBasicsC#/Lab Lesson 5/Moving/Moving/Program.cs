using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            int side3 = int.Parse(Console.ReadLine());
            int freeSpace = side1 * side2 * side3;

            int boxes = 0;
            string command = Console.ReadLine();
            while (command != "Done")
            {
                int numBoxes = int.Parse(command);
                boxes += numBoxes;
                if (boxes > freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {boxes - freeSpace} Cubic meters more.");
                    return;
                }
                command = Console.ReadLine();

            }
            Console.WriteLine($"{freeSpace - boxes} Cubic meters left.");
        }
    }
}
