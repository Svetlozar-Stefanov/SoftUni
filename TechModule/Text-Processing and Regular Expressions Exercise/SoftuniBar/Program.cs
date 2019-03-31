using System;
using System.Text.RegularExpressions;

namespace SoftuniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;
            while (input != "end of shift")
            {
                Match info = Regex.Match(input, @"%(?<name>[A-Z][a-z]+)%([^$%.|]|)+<(?<product>\w+)>([^$%.|]|)+\|(?<count>\d+)\|([^\d$%.|]|)+(?<price>[0-9]*\.?[0-9]+)(?=\$)");

                if (info.Success)
                {
                    string customer = info.Groups["name"].Value;
                    string product = info.Groups["product"].Value;
                    int count = int.Parse(info.Groups["count"].Value);
                    double price = double.Parse(info.Groups["price"].Value);
                    double sum = price * count;

                    Console.WriteLine($"{customer}: {product} - {sum:f2}");
                    totalSum += sum;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
