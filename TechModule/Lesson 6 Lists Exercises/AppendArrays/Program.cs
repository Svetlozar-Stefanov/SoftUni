using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|").ToList();

            list.Reverse();
            string listStr = "";
            for (int i = 0; i < list.Count; i++)
            {
                listStr += " " + list[i];
            }
            string[] result = listStr.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
