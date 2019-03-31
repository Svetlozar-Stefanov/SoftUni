using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surprise
{
    class Program
    {
        static void Main(string[] args)
        {
            double brotherA = double.Parse(Console.ReadLine());
            double brotherB = double.Parse(Console.ReadLine());
            double brotherC = double.Parse(Console.ReadLine());
            double fatherD = double.Parse(Console.ReadLine());

            double time = 1 / (1/brotherA + 1/brotherB + 1/brotherC);
            double timeWithRest = time + (time * 0.15);
            double timeLeft = fatherD - timeWithRest;

            Console.WriteLine($"Cleaning time: {timeWithRest:f2}");
            if (timeLeft > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(Math.Abs(timeLeft))} hours.");
            }


        }
    }
}
