using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double total = 0;

            if (typeOfPeople == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
                total = numPeople * price;
                if (numPeople >= 30)
                {
                    total = total - (total * 0.15);
                }
            }
            else if (typeOfPeople == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
                if (numPeople >= 100)
                {
                    numPeople -= 10;
                }
                total = numPeople * price;
            }
            else if (typeOfPeople == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
                total = numPeople * price;
                if (numPeople >= 10 && numPeople <= 20)
                {
                    total = total - (total * 0.05);
                }
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
