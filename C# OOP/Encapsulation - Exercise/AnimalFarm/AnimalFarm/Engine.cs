using System;

namespace AnimalFarm
{
    static class Engine
    {
        private static Chicken chicken;
        public static void Run()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                chicken = new Chicken(name, age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.");
        }
    }
}
