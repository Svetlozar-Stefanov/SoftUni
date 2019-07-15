using System;
using WildFarm.Models.AbstractClasses;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Mammals.Felines
{
    public class Cat : Feline
    {
        protected override double WeightGain => 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string MakeSound()
        {
            return "Meow";
        }

        public override void Eat(Food food)
        {
            if (food.GetType() != typeof(Vegetable)
                && food.GetType() != typeof(Meat))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            FoodEaten += food.Quantity;
            Weight += WeightGain * food.Quantity;
        }


    }
}
