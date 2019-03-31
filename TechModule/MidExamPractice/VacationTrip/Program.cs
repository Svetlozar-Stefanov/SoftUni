using System;

namespace VacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            decimal fuelPrice = decimal.Parse(Console.ReadLine());
            decimal foodExpenses = decimal.Parse(Console.ReadLine());
            decimal roomPrice = decimal.Parse(Console.ReadLine());

            decimal totalFoodExpenses = daysOfTrip * people * foodExpenses;
            decimal roomExpenses = daysOfTrip * people * roomPrice;

            if (people > 10)
            {
                roomExpenses = roomExpenses - (roomExpenses * 0.25m);
            }
            decimal expensess = totalFoodExpenses + roomExpenses;
            for (int i = 1; i <= daysOfTrip; i++)
            {
                if (expensess > budget)
                {
                    break;
                }

                decimal kmsPerDay = decimal.Parse(Console.ReadLine());
                decimal fuelExpenses = fuelPrice * kmsPerDay;
                expensess += fuelExpenses;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    expensess = expensess + (expensess * 0.4m);
                }
                if (i % 7 == 0)
                {
                    expensess = expensess - (expensess / people);
                }
            }
            if (expensess > budget)
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {expensess - budget:f2}$ more.");
            }
            else
            {
                Console.WriteLine($"You have reached the destination. You have {budget - expensess:f2}$ budget left.");
            }
        }
    }
}
