using System;

namespace PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());


            int money = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                money += 50;
                money -= 2 * partySize;

                if (i % 3 == 0)
                {
                    money -= partySize * 3;
                }
                if (i % 5 == 0)
                {
                    money += 20 * partySize;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    money -= 2 * partySize;
                }
            }

            Console.WriteLine($"{partySize} companions received {money / partySize} coins each.");
        }
    }
}
