namespace Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class ClothesRack
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ",StringSplitOptions.RemoveEmptyEntries);

                string colour = input[0];
                string[] clothes = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                }
                foreach (var piece in clothes)
                {
                    if (!wardrobe[colour].ContainsKey(piece))
                    {
                        wardrobe[colour][piece] = 0;
                    }
                    wardrobe[colour][piece]++;
                }
            }

            string[] search = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var piece in wardrobe)
            {
                Console.WriteLine($"{piece.Key} clothes:");
                foreach (var info in piece.Value)
                {
                    if (piece.Key == search[0] && info.Key == search[1])
                    {
                        Console.WriteLine($"* {info.Key} - {info.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {info.Key} - {info.Value}");
                    }
                }
            }

        }
    }
}
