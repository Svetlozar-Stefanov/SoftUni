using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnBussiness
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int space = w * l * h;
            int fillSpace = 0;

            for (int i = 0; ; i++)
            {
                string input = Console.ReadLine();
                if (input == "Done" && space >= fillSpace)
                {
                    Console.WriteLine($"{space - fillSpace} Cubic meters left.");
                    break;
                }
                fillSpace += int.Parse(input);
                if (space < fillSpace)
                {
                    Console.WriteLine($"No more free space! You need {fillSpace - space} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
