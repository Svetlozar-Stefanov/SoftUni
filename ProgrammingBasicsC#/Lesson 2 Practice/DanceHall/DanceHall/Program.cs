using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double sHall = (L * 100) * (W * 100);
            double sWardrobe = (A * 100) * (A * 100);
            double sBench = sHall / 10;

            double freeSpace = sHall - (sWardrobe + sBench);
            double dancers = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
