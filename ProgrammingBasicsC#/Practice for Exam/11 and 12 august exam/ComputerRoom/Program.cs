using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string seasson = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            double totalSum = 0;
            double pricePerson = 0;

            if (seasson == "march" || seasson == "april" || seasson == "may")
            {
                if (timeOfDay == "day")
                {
                    pricePerson = 10.50;
                }
                if (timeOfDay == "night")
                {
                    pricePerson = 8.40;
                }
            }
            if (seasson == "june" || seasson == "july" || seasson == "august")
            {
                if (timeOfDay == "day")
                {
                    pricePerson = 12.60;
                }
                if (timeOfDay == "night")
                {
                    pricePerson = 10.20;
                }
            }

            if (people >= 4)
            {
                pricePerson = pricePerson - (pricePerson * 0.10);
            }
            if (hours >= 5)
            {
                pricePerson = pricePerson - (pricePerson * 0.50);
            }
            totalSum = pricePerson * hours * people;


            Console.WriteLine($"Price per person for one hour: {pricePerson:f2}");
            Console.WriteLine($"Total cost of the visit: {totalSum:f2}");
        }
    }
}
