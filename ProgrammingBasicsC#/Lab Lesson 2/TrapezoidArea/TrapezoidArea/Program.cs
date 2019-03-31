using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            
            double degrees = radian*180/Math.PI;

            Console.WriteLine(Math.Round(degrees));


        }
    }
}
