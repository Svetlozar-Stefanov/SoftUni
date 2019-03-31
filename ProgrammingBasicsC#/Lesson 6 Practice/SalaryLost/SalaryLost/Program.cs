using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryLost
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string website = Console.ReadLine().ToLower();
                if (website == "facebook")
                {
                    salary -= 150;
                }
                if (website == "instagram")
                {
                    salary -= 100;
                }
                if (website == "reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine(salary);
        }
    }
}
