using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string seasson = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (seasson == "may" || seasson == "october")
            {
                studioPrice = 50 * nights;
                apartmentPrice = 65 * nights;

                if (nights > 7 && nights <= 14)
                {
                    studioPrice = studioPrice - (studioPrice * 0.05);
                }
                else if (nights > 14)
                {
                    studioPrice = studioPrice - (studioPrice * 0.3);
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.1);
                }
            }
            else if (seasson == "june" || seasson == "september")
            {
                studioPrice = 75.2 * nights;
                apartmentPrice = 68.7 * nights;

                if (nights > 14)
                {
                    studioPrice = studioPrice - (studioPrice * 0.2);
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.1);
                }
            }
            else if (seasson == "july" || seasson == "august")
            {
                studioPrice = 76 * nights;
                apartmentPrice = 77 * nights;

                if (nights > 14)
                {
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.1);
                }
            }


            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
