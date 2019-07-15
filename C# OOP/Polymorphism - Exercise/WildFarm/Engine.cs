using System;
using System.Collections.Generic;
using WildFarm.Models;
using WildFarm.Models.Birds;
using WildFarm.Models.Foods;
using WildFarm.Models.Mammals;
using WildFarm.Models.Mammals.Felines;

namespace WildFarm
{
    public class Engine
    {
        private List<Animal> animals = new List<Animal>();

        private List<Food> foods = new List<Food>();

        public void Run()
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] foodInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0].ToLower() != "end")
            {
                TakeAnimals(input);
                TakeFood(foodInput);

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0].ToLower() == "end")
                {
                    break;
                }
                foodInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            FeedAnimals();
            PrintAnimals();
        }

        private void PrintAnimals()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private void FeedAnimals()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                Animal animal = animals[i];
                Food food = foods[i];

                Console.WriteLine(animal.MakeSound());
                try
                {
                    animal.Eat(food);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void TakeFood(string[] foodInput)
        {
            string foodType = foodInput[0].ToLower();
            int quantity = int.Parse(foodInput[1]);
            if (foodType == "vegetable")
            {
                Vegetable vegetable = new Vegetable(quantity);
                foods.Add(vegetable);
            }
            else if (foodType == "fruit")
            {
                Fruit fruit = new Fruit(quantity);
                foods.Add(fruit);
            }
            else if (foodType == "meat")
            {
                Meat meat = new Meat(quantity);
                foods.Add(meat);
            }
            else if (foodType == "seeds")
            {
                Seeds seeds = new Seeds(quantity);
                foods.Add(seeds);
            }
        }

        private void TakeAnimals(string[] input)
        {
            string type = input[0].ToLower();

            if (type == "owl")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                double wingSize = double.Parse(input[3]);

                Owl owl = new Owl(name, weight, wingSize);
                animals.Add(owl);
            }
            else if (type == "hen")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                double wingSize = double.Parse(input[3]);

                Hen hen = new Hen(name, weight, wingSize);
                animals.Add(hen);
            }
            else if (type == "mouse")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                string region = input[3];

                Mouse mouse = new Mouse(name, weight, region);
                animals.Add(mouse);
            }
            else if (type == "dog")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                string region = input[3];

                Dog dog = new Dog(name, weight, region);
                animals.Add(dog);
            }
            else if (type == "cat")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                string region = input[3];
                string breed = input[4];

                Cat cat = new Cat(name, weight, region, breed);
                animals.Add(cat);
            }
            else if (type == "tiger")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                string region = input[3];
                string breed = input[4];

                Tiger tiger = new Tiger(name, weight, region, breed);
                animals.Add(tiger);
            }
        }
    }
}
