using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double size = double.Parse(Console.ReadLine());
            double comission = -1;


            if (city == "sofia")
            {
                if (size >= 0 && size <= 500)
                {
                    comission = 0.05;
                }

                else if (size > 500 && size <= 1000 )
                {
                    comission = 0.07;
                }

                else if (size > 1000 && size <= 10000)
                {
                    comission = 0.08;
                }

                else if (size > 10000)
                {
                    comission = 0.12;
                }
            }

            else if (city == "varna")
            {
                if (size >= 0 && size <= 500)
                {
                    comission = 0.045;
                }

                else if (size > 500 && size <= 1000)
                {
                    comission = 0.075;
                }

                else if (size > 1000 && size <= 10000)
                {
                    comission = 0.1;
                }

                else if (size > 10000)
                {
                    comission = 0.13;
                }
            }

            else if (city == "plovdiv")
            {
                if (size >= 0 && size <= 500)
                {
                    comission = 0.055;
                }

                else if (size > 500 && size <= 1000)
                {
                    comission = 0.08;
                }

                else if (size > 1000 && size <= 10000)
                {
                    comission = 0.12;
                }

                else if (size > 10000)
                {
                    comission = 0.145;
                }
            }

            double finalSum = size * comission;

            if (comission > 0)
            {
                Console.WriteLine($"{finalSum:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
