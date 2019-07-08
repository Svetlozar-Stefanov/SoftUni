using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public static class Engine
    {
        private static List<Person> people = new List<Person>();

        private static List<Product> products = new List<Product>();

        public static void Run()
        {
            List<KeyValuePair<string, int>> peopleInfo = GatherInfo();
            foreach (var (name,money) in peopleInfo)
            {
                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }

            List<KeyValuePair<string, int>> productInfo = GatherInfo();
            foreach (var (name,price) in productInfo)
            {
                try
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }


            string[] command = Console.ReadLine()
                .Split(" ");
            while (command[0].ToLower() != "end")
            {
                Person person = people.FirstOrDefault(p => p.Name == command[0]);
                Product product = products.FirstOrDefault(p => p.Name == command[1]);

                if (person != null && product != null)
                {
                    person.AddProduct(product);
                }

                command = Console.ReadLine()
                .Split(" ");
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

        }

        private static List<KeyValuePair<string,int>> GatherInfo()
        {
            string[] input = Console.ReadLine()
                            .Split(";",StringSplitOptions.RemoveEmptyEntries);
            List<KeyValuePair<string, int>> info = new List<KeyValuePair<string, int>>();
            foreach (var item in input)
            {
                string[] splitInfo = item
                    .Split("=",StringSplitOptions.RemoveEmptyEntries);

                string name = splitInfo[0];
                int money = int.Parse(splitInfo[1]);

                var pair = new KeyValuePair<string, int>(name, money);
                info.Add(pair);
            }
            return info;
        }
    }
}
