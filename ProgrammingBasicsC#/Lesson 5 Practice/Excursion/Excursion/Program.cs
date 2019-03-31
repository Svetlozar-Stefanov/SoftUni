using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyNeeded = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            int dayCounter = 0;
            int spendCounter = 0;

            while (budget < moneyNeeded)
            {
                string command = Console.ReadLine();
                decimal moneyActivity = decimal.Parse(Console.ReadLine());
                dayCounter++;

                if (command == "save")
                {
                    budget += moneyActivity;
                    spendCounter = 0;
                }
                else if (command == "spend")
                {
                    spendCounter++;
                    budget -= moneyActivity;
                    if (budget < 0)
                    {
                        budget = 0;
                    }
                    if (spendCounter >= 5)
                    {
                        Console.WriteLine($"You can't save the money." + Environment.NewLine + dayCounter);
                       
                        return;
                    }
                }
            }
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            

        }
    }
}
