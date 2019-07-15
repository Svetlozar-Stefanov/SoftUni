using System;
using WildFarm.Models.AbstractClasses;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Mammals
{
    public class Mouse : Mammal
    {
        protected override double WeightGain => 0.10;

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType() != typeof(Vegetable)
                && food.GetType() != typeof(Fruit))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            
            FoodEaten += food.Quantity;
            Weight += WeightGain * food.Quantity;
        }

        public override string MakeSound()
        {
            return "Squeak";
        }
    }
}
