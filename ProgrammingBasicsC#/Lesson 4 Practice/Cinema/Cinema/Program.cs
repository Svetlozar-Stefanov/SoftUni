using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double moviePrice = 0;

            if (typeOfMovie == "Premiere")
            {
                moviePrice = 12;
            }

            else if (typeOfMovie == "Normal")
            {
                moviePrice = 7.5;
            }

            else if (typeOfMovie == "Discount")
            {
                moviePrice = 5;
            }

            double totalIncome = (r * c) * moviePrice;
            Console.WriteLine($"{totalIncome:f2} leva");

        }
    }
}
