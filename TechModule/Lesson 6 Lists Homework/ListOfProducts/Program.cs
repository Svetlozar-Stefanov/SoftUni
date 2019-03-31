using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfFood = new List<string>();
            int products = int.Parse(Console.ReadLine());

            for (int i = 0; i < products; i++)
            {
                string food = Console.ReadLine();
                listOfFood.Add(food);
            }

            listOfFood.Sort();

            for (int i = 0; i < listOfFood.Count; i++)
            {
                Console.WriteLine($"{i+1}.{listOfFood[i]}");
            }
        }
    }
}
