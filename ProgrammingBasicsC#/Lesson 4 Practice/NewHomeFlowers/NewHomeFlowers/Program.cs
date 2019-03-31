using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHomeFlowers
{
    class Program
    {
        static void Main(string[] args)
        {


            string typeOfFlower = Console.ReadLine();
            double numberOfFlowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double rose = 5;
            double dahlias = 3.8;
            double tulip = 2.8;
            double narcissus = 3;
            double gladiolus = 2.5;

            double finalPrice = 0;
            

            if (typeOfFlower == "Roses")
            {
                finalPrice = numberOfFlowers * rose;
                if (numberOfFlowers > 80)
                {
                    finalPrice *= 0.9;
                }


            }

            else if (typeOfFlower == "Dahlias")
            {
                finalPrice = numberOfFlowers * dahlias;
                if (numberOfFlowers > 90)
                {
                    finalPrice *= 0.85;
                }

            }

            else if (typeOfFlower == "Tulips")
            {
                finalPrice = numberOfFlowers * tulip;
                if (numberOfFlowers > 80)
                {
                    finalPrice *= 0.85;
                }

            }

            else if (typeOfFlower == "Narcissus")
            {
                finalPrice = numberOfFlowers * narcissus;
                if (numberOfFlowers < 120)
                {
                    finalPrice *= 1.15;
                }

            }

            else if (typeOfFlower == "Gladiolus")
            {
                finalPrice = numberOfFlowers * gladiolus;
                if (numberOfFlowers < 80)
                {
                    finalPrice *= 1.2;
                }

            }



            if (finalPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need {finalPrice - budget:F2} leva more.");
            }
            else
            {
                
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlower} and {budget - finalPrice:f2} leva left.");

            }

        }
    }
}
