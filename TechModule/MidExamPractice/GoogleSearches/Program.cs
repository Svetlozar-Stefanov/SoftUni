using System;

namespace GoogleSearches
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int users = int.Parse(Console.ReadLine());
            double moneyPerSearch = double.Parse(Console.ReadLine());
            double totalMoney = 0;

            for (int i = 1; i <= users; i++)
            {
                double currentMoney = 0;
                int searchLength = int.Parse(Console.ReadLine());
                if (searchLength > 5)
                {
                    continue;
                }

                currentMoney = moneyPerSearch;

                if (searchLength == 1)
                {
                    currentMoney *= 2;
                }
                if (i % 3 == 0)
                {
                    currentMoney *= 3;
                }
                totalMoney += currentMoney;
            }

            totalMoney *= days;
            Console.WriteLine($"Total money earned for {days} days: {totalMoney:f2}");
        }
    }
}
