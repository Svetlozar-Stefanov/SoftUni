namespace Restaurant
{
    public class Fish : MainDish
    {
        public Fish(string name, decimal price)
            : base(name, price, Grams)
        { 

        }

        const double Grams = 22;
    }
}
