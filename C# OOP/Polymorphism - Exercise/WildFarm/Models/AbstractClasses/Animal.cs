using WildFarm.Contracts;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public virtual string Name { get; protected set; }

        public virtual double Weight { get; protected set; }

        public virtual int FoodEaten { get; protected set; }

        public abstract void Eat(Food food);

        public abstract string MakeSound();
    }
}
