using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;

        private int money;

        private List<Product> shoppingBag;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            shoppingBag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                Validator.CheckName(value);
                name = value;
            }
        }

        public int Money
        {
            get
            {
                return money;
            }
            private set
            {
                Validator.CheckNumValue(value);
                money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (Money < product.Price)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
                return;
            }

            shoppingBag.Add(product);
            Money -= product.Price;
            Console.WriteLine($"{Name} bought {product.Name}");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} - ");
            if (shoppingBag.Count == 0)
            {
                sb.Append("Nothing bought");
            }
            else
            {
                sb.Append(string.Join(", ", shoppingBag.Select(p => p.Name)));
            }

            return sb.ToString().TrimEnd();
        }
    }
}
