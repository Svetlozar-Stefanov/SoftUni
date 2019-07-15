namespace WildFarm.Models.Birds
{
    public class Hen : Bird
    {
        private const double weightGain = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.Quantity;

            Weight += weightGain * food.Quantity;
        }

        public override string MakeSound()
        {
            return "Cluck";
        }
    }
}
