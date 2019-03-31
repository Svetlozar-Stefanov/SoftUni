using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string review = Console.ReadLine();

            int nights = daysStay - 1;
            double stayPrice = 0;

            if (roomType == "room for one person")
            {
                stayPrice = nights * 18.00;
            }
            if (roomType == "apartment")
            {
                stayPrice = nights * 25.00;
                if (daysStay < 10)
                {
                    stayPrice *= 0.70;
                }
                if (daysStay >= 10 && daysStay <= 15)
                {
                    stayPrice *= 0.65;
                }
                if (daysStay > 15)
                {
                    stayPrice *= 0.50;
                }
            }
            if (roomType == "president apartment")
            {
                stayPrice = nights * 35.00;
                if (daysStay < 10)
                {
                    stayPrice *= 0.90;
                }
                if (daysStay >= 10 && daysStay <= 15)
                {
                    stayPrice *= 0.85;
                }
                if (daysStay > 15)
                {
                    stayPrice *= 0.80;
                }
            }

            if (review == "positive")
            {
                stayPrice = stayPrice + (stayPrice * 0.25);
            }
            else
            {
                stayPrice = stayPrice - (stayPrice * 0.1);
            }

            Console.WriteLine($"{stayPrice:f2}");
        }
    }
}
