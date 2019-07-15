using System;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Birds
{
    public class Owl : Bird
    {
        private const double weightGain = 0.25;

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType() != typeof(Meat))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            FoodEaten = food.Quantity;
            Weight += weightGain * food.Quantity;
        }

        public override string MakeSound()
        {
            return "Hoot Hoot";
        }
    }
}
