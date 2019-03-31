using System;

namespace EinsteinRiddle
{
    class Program
    {
        static string[] houses = { "Red", "Green", "Yellow", "White", "Blue" };
        static string[] pets = { "Dog", "Cat", "Bird", "Horse", "Fish" };
        static string[] nationalities = { "Brit", "Swede", "Dane", "Norwegian", "Geramn" };
        static string[] cigarettes = { "Blen", "Prince", "Dunhill", "BlueMaster", "PullMall" };
        static string[] drinks = { "Tea", "Coffee", "Milk", "Beer", "Water" };
        static string[] hints = new string[15];

        static void Main(string[] args)
        {
            Random rand = new Random();

            Shuffle(rand);

            GenarateHints();

            Console.WriteLine("Einstein's riddle");
            Console.WriteLine();
            Console.WriteLine("The situation");
            Console.WriteLine("     1.There are 5 houses in five different colors.");
            Console.WriteLine("     2.In each house lives a person with a different nationality.");
            Console.WriteLine("     3.These five owners drink a certain type of beverage, smoke a certain brand of cigar and keep a certain pet.");
            Console.WriteLine("     4.No owners have the same pet, smoke the same brand of cigar or drink the same beverage.");
            Console.WriteLine();
            Console.WriteLine($"The question is: Who owns the {pets[4]}?");

            Console.WriteLine("HINTS:");
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine($"{i}.{hints[i - 1]}");
            }


            Console.WriteLine();
            Console.WriteLine("Einstein wrote this riddle this century. He said that 98% of the world could not solve it. ");
            Console.WriteLine("To see the solution type solution");

            string solution = Console.ReadLine();
            while (solution.ToLower() != "solution")
            {
                Console.WriteLine("Wrong command! Try again!");
                solution = Console.ReadLine();
            }
            PrintSolution();
        }

        private static void PrintSolution()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"In the {houses[i]} lives the {nationalities[i]}. He drinks {drinks[i]}, smokes {cigarettes[i]} and has {pets[i]} as pet.");
            }
        }

        private static void GenarateHints()
        {
            hints[0] = $"the {nationalities[0]} lives in the {houses[0]} house";
            hints[1] = $"the {nationalities[1]} keeps {pets[0]} as pets";
            hints[2] = $"the {nationalities[2]} drinks {drinks[0]}";
            hints[3] = $"the {houses[1]} house is on the left of the {houses[2]} house";
            hints[4] = $"the {houses[4]} house's owner drinks {drinks[1]}";
            hints[5] = $"the person who smokes {cigarettes[4]} rears {pets[2]}";
            hints[6] = $"the owner of the {houses[2]} house smokes {cigarettes[2]}";
            hints[7] = $"the man living in the center house drinks {drinks[2]}";
            hints[8] = $"the {nationalities[3]} lives in the first house";
            hints[9] = $"the man who smokes {cigarettes[0]} lives next to the one who keeps {pets[1]}";
            hints[10] = $"the man who keeps {pets[3]} lives next to the man who smokes {cigarettes[2]}";
            hints[11] = $"the owner who smokes {cigarettes[3]} drinks {drinks[3]}";
            hints[12] = $"the {nationalities[4]} smokes {cigarettes[1]}";
            hints[13] = $"the {nationalities[3]} lives next to the {houses[4]} house";
            hints[14] = $"the man who smokes {cigarettes[0]} has a neighbor who drinks {drinks[4]}";
        }

        private static void Shuffle(Random rand)
        {
            for (int i = 0; i < 5; i++)
            {
                int randomHouse = i + rand.Next(0, houses.Length - i);
                Swap(i, randomHouse, houses);

                int randomPet = i + rand.Next(0, pets.Length - i);
                Swap(i, randomPet, pets);

                int randomNationality = i + rand.Next(0, nationalities.Length - i);
                Swap(i, randomNationality, nationalities);

                int randomCigarette = i + rand.Next(0, cigarettes.Length - i);
                Swap(i, randomCigarette, cigarettes);

                int randomDrinks = i + rand.Next(0, drinks.Length - i);
                Swap(i, randomDrinks, drinks);
            }
        }

        private static void Swap(int i, int random, string[] array)
        {
            string temp = array[i];
            array[i] = array[random];
            array[random] = temp;
        }
    }
}
