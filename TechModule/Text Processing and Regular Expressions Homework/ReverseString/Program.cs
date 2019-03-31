using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                List<char> strArr = input.ToCharArray().ToList();
                strArr.Reverse();

                Console.WriteLine($"{input} = {String.Join("", strArr)}");
                input = Console.ReadLine();
            }
        }
    }
}
