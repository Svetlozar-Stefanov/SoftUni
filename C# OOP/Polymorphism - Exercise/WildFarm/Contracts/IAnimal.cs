using WildFarm.Models;

namespace WildFarm.Contracts
{
    interface IAnimal
    {
        string Name { get; }

        double Weight { get; }

        int FoodEaten { get; }

        string MakeSound();

        void Eat(Food food);
    }
}
