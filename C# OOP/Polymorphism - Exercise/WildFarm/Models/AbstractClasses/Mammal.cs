using System;
using WildFarm.Models.Foods;

namespace WildFarm.Models.AbstractClasses
{
    public abstract class Mammal : Animal
    {
        protected virtual double WeightGain { get; } = 0;
        protected Mammal(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            LivingRegion = livingRegion;
        }

        public virtual string LivingRegion { get; protected set; }

        public override void Eat(Food food)
        {
            if (food.GetType() != typeof(Meat))
            {
                throw new InvalidOperationException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
            FoodEaten = food.Quantity;
            Weight += WeightGain * food.Quantity;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
