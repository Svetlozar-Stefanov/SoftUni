using System;
using System.Collections.Generic;

namespace ShoppingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();
            string[] personInfo = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < personInfo.Length; i++)
            {
                string currentInfo = personInfo[i];
                string[] nameAndMoney = currentInfo.Split('=');
                string name = nameAndMoney[0];
                decimal money = decimal.Parse(nameAndMoney[1]);
                listPerson.Add(new Person(name, money));
            }

            List<Product> productVariety = new List<Product>();
            string[] productInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productInfo.Length; i++)
            {
                string currentInfo = productInfo[i];
                string[] nameAndPrice = currentInfo.Split('=');
                string name = nameAndPrice[0];
                decimal price = decimal.Parse(nameAndPrice[1]);
                productVariety.Add(new Product(name, price));
            }

            string[] input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                string customerName = input[0];
                string productName = input[1];
                foreach (var person in listPerson)
                {
                    if (person.Name == customerName)
                    {
                        person.Buy(productVariety, productName);
                    }
                }

                input = Console.ReadLine().Split();
            }

            foreach (var person in listPerson)
            {
                if (person.ShoppingBag.Count > 0)
                {
                    Console.Write(person.Name + " - ");
                    for (int i = 0; i < person.ShoppingBag.Count; i++)
                    {
                        Console.Write(person.ShoppingBag[i].Name);
                        if (i != person.ShoppingBag.Count-1)
                        {
                            Console.Write(", ");
                        }
                    }
                    
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }

    class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            ShoppingBag = new List<Product>();
        }
        public string Name;
        public decimal Money;
        public List<Product> ShoppingBag;

        internal void Buy(List<Product> productVariety, string productName)
        {
            foreach (var product in productVariety)
            {
                if (product.Name == productName)
                {
                    if (Money >= product.Cost)
                    {
                        Money -= product.Cost;
                        ShoppingBag.Add(product);
                        Console.WriteLine($"{Name} bought {productName}");
                    }
                    else
                    {
                        Console.WriteLine($"{Name} can't afford {productName}");
                    }
                }
            }
        }
    }

    class Product
    {
        public string Name;
        public decimal Cost;

        public Product(string name, decimal price)
        {
            Name = name;
            this.Cost = price;
        }
    }
}
