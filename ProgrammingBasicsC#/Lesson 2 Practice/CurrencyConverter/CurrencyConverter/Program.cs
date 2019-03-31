using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = 1.79549;

            double EUR = 1.95583;

            double GBP = 2.53405;

            double sum = double.Parse(Console.ReadLine());

            string currecy1 = Console.ReadLine();

            string currency2 = Console.ReadLine();



            if (currecy1 == "BGN")

            {

                if (currency2 == "USD")

                {

                    Console.WriteLine("{0:f2} USD", sum / USD);

                }

                else if (currency2 == "EUR")

                {

                    Console.WriteLine("{0:f2} EUR", sum / EUR);

                }

                else if (currency2 == "GBP")

                {

                    Console.WriteLine("{0:f2} GBP", sum / GBP);

                }

            }

            if (currecy1 == "USD")

            {

                sum = sum * USD;

                if (currency2 == "BGN")

                {

                    Console.WriteLine("{0:f2} BGN", sum);

                }

                else if (currency2 == "EUR")

                {

                    Console.WriteLine("{0:f2} EUR", sum / EUR);

                }

                else if (currency2 == "GBP")

                {

                    Console.WriteLine("{0:f2} GBP", sum / GBP);

                }

            }

            if (currecy1 == "EUR")

            {

                sum = sum * EUR;

                if (currency2 == "BGN")

                {

                    Console.WriteLine("{0:f2} BGN", sum);

                }

                else if (currency2 == "USD")

                {

                    Console.WriteLine("{0:f2} USD", sum / USD);

                }

                else if (currency2 == "GBP")

                {

                    Console.WriteLine("{0:f2} GBP", sum / GBP);

                }

            }

            if (currecy1 == "GBP")

            {

                sum = sum * GBP;

                if (currency2 == "BGN")

                {

                    Console.WriteLine("{0:f2} BGN", sum);

                }

                else if (currency2 == "EUR")

                {

                    Console.WriteLine("{0:f2} EUR", sum / EUR);

                }

                else if (currency2 == "USD")

                {

                    Console.WriteLine("{0:f2} USD", sum / USD);

                }

            }
        }
    }
}
