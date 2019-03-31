using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int coinCounter = 0;
            sum *= 100;

            while (sum >= 200)
            {
                sum -= 200;
                coinCounter++;
            }
            while (sum >= 100)
            {
                sum -= 100;
                coinCounter++;
            }
            while (sum >= 50)
            {
                sum -= 50;
                coinCounter++;
            }
            while (sum >= 20)
            {
                sum -= 20;
                coinCounter++;
            }
            while (sum >= 10)
            {
                sum -= 10;
                coinCounter++;
            }
            while (sum >= 5)
            {
                sum -= 5;
                coinCounter++;
            }
            while (sum >= 2)
            {
                sum -= 2;
                coinCounter++;
            }
            while (sum >= 1)
            {
                sum -= 1;
                coinCounter++;
            }
            Console.WriteLine(coinCounter);
        }

    }
}
