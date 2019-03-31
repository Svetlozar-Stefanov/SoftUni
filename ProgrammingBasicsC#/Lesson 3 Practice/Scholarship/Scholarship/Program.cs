using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double profit = double.Parse(Console.ReadLine());
            double grades = double.Parse(Console.ReadLine());
            double minProfit = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double scholarship = 0;

            if (profit < minProfit && grades > 4.5)
            {
                socialScholarship = minProfit * 0.35;

            }

            if (grades >= 5.5)
            {
                scholarship = grades * 25;
            }

            if (socialScholarship <= scholarship && socialScholarship != 0 || scholarship != 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarship)} BGN");
            }

            else if (socialScholarship > scholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }

            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }


        }
    }
}
