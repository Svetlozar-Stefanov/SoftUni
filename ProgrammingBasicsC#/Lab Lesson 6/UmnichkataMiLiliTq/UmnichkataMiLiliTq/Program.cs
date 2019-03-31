using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmnichkataMiLiliTq
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int numOfToys = 0;
            int moneySum = 0;
            int moneyYearsCounter = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyYearsCounter++;
                    moneySum = moneySum + 10 * moneyYearsCounter;
                }
                else
                {
                    numOfToys++;
                }
            }
            int birthdayMoney = moneySum - moneyYearsCounter;
            int toysSum = toyPrice * numOfToys;
            int total = birthdayMoney + toysSum;

            if (total >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(total - washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice - total):f2}");
            }
        }
    }
}
