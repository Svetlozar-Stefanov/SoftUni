using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Perimeter_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
