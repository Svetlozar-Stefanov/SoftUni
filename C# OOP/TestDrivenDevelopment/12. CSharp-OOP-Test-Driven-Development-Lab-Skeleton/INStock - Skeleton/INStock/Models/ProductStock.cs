using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using INStock.Contracts;

namespace INStock.Models
{
    public class ProductStock : IProductStock
    {
        private List<IProduct> products;

        public ProductStock()
        {
            products = new List<IProduct>();
        }

        public IProduct this[int index] { get => products[index]; }

        public int Count => products.Count;

        public void Add(IProduct product)
        {
            if (product == null)
            {
                throw new InvalidOperationException("Cannot add null");
            }
            if (products.Any(p => p.Label == product.Label && p.Price != product.Price))
            {
                throw new InvalidOperationException("Cannot add existing product with different price");
            }
            if (products.Any(p => p.Label == product.Label && p.Price == product.Price))
            {
                products.FirstOrDefault(p => p.Label == product.Label).Quantity += product.Quantity;
            }

            products.Add(product);
        }

        public bool Contains(IProduct product)
        {
            if (product == null)
            {
                throw new InvalidOperationException("Cannot accept null");
            }
            return products.Contains(product);
        }

        public IProduct Find(int index)
        {
            return products[index - 1];
        }

        public IEnumerable<IProduct> FindAllByPrice(decimal price)
        {
            if (price <= 0)
            {
                throw new ArgumentException("Cannot be zero or negative");
            }

            List<IProduct> products = new List<IProduct>();

            products.AddRange(this.products.Where(p => p.Price == price));

            return products;
        }

        public IEnumerable<IProduct> FindAllByQuantity(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException("Cannot be negative");
            }

            List<IProduct> products = new List<IProduct>();

            products.AddRange(this.products.Where(p => p.Quantity == quantity));

            return products;
        }

        public IEnumerable<IProduct> FindAllInRange(decimal lo, decimal hi)
        {
            if (lo < 0 || hi < 0)
            {
                throw new ArgumentException("Cannot be zero or negative");
            }

            List<IProduct> products = new List<IProduct>();

            products.AddRange(this.products.Where(p => p.Price >= lo && p.Price <= hi));

            return products;
        }

        public IProduct FindByLabel(string label)
        {
            if (string.IsNullOrEmpty(label))
            {
                throw new ArgumentException("Cannot be null or empty");
            }
            return products.FirstOrDefault(p => p.Label == label);
        }

        public IProduct FindMostExpensiveProduct()
        {
            IProduct theChosenOne = null;
            decimal max = decimal.MinValue;

            foreach (var product in products)
            {
                if (product.Price > max)
                {
                    theChosenOne = product;
                    max = product.Price;
                }
            }

            return theChosenOne;
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            return products.GetEnumerator();
        }

        public bool Remove(IProduct product)
        {
            return products.Remove(product);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return products.GetEnumerator();
        }
    }
}
