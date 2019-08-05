using INStock.Contracts;
using System;

namespace INStock.Models
{
    public class Product : IProduct
    {
        private string label;
        private decimal price;
        private int quantity;

        public Product(string label, decimal price, int quantity)
        {
            Label = label;
            Price = price;
            Quantity = quantity;

        }

        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be null or empty");
                }

                label = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot be zero or negative");
                }

                price = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot be negative");
                }

                quantity = value;
            }
        }
        public int CompareTo(IProduct other)
        {
            throw new System.NotImplementedException();
        }
    }
}
