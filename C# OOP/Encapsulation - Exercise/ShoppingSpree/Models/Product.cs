namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;

        private int price;

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
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

        public int Price
        {
            get
            {
                return price;
            }
            private set
            {
                Validator.CheckNumValue(value);
                price = value;
            }
        }


    }
}
