using BorderControl.CityInhabitants;
using BorderControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public static class Engine
    {
        public static List<IBuyer> buyers = new List<IBuyer>();
        public static void Run()
        {
            int numberOfHabitants = int.Parse(Console.ReadLine());

            InitializeBuyers(numberOfHabitants);

            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                BuyNeededFood(input);

                input = Console.ReadLine();
            }

            int sum = buyers.Sum(b => b.Food);
            Console.WriteLine(sum);
        }

        private static void BuyNeededFood(string input)
        {
            if (buyers.Contains(buyers.FirstOrDefault(b => b.Name == input)))
            {
                IBuyer buyer = buyers.FirstOrDefault(b => b.Name == input);
                buyer.BuyFood();
            }
        }

        private static void InitializeBuyers(int numberOfHabitants)
        {
            for (int i = 0; i < numberOfHabitants; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdate = input[3];

                    IBuyer citizen = new Citizen(name, age, id, birthdate);
                    buyers.Add(citizen);
                }
                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    IBuyer rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
            }
        }
    }
}
