using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int etages = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = etages; i > 0 ; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i == etages || etages == 1)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");

                    }
                    else if (i % 2 != 0)
                    {
                        Console.Write($"A{i}{j} ");

                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
