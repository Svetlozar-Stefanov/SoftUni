using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());



            double volumeInCubicCantimetres = length * width * height;
            double volumeInLIters = volumeInCubicCantimetres / 1000;

            double noNeededPercent = percent * 0.01;
            double finalResult = volumeInLIters * (1 - noNeededPercent);

            Console.WriteLine($"{finalResult:F3}");
        }
    }
}
