namespace Task1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] secondInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquids = new Queue<int>(firstInput);
            Stack<int> items = new Stack<int>(secondInput);

            Dictionary<int, string> advancedMaterials = new Dictionary<int, string>()
            {
                { 25,"Glass" },
                { 50,"Aluminium" },
                { 75,"Lithium" },
                { 100,"Carbon fiber" }
            };

            Dictionary<string, int> createdParts = new Dictionary<string, int>()
            {
                {"Glass", 0 },
                {"Aluminium", 0 },
                {"Lithium",0 },
                {"Carbon fiber",0 }
            };

            while (liquids.Count > 0 && items.Count > 0)
            {
                int liquidValue = liquids.Dequeue();
                int itemValue = items.Peek();
                int sum = liquidValue + itemValue;
                if (advancedMaterials.ContainsKey(sum))
                {
                    items.Pop();
                    string newMaterial = advancedMaterials[sum];

                    if (!createdParts.ContainsKey(newMaterial))
                    {
                        createdParts[newMaterial] = 0;
                    }
                    createdParts[newMaterial]++;
                }
                else
                {
                    items.Pop();
                    items.Push(itemValue + 3);
                }
            }

            bool canBild = true;
            foreach (var part in createdParts)
            {
                if (part.Value <= 0)
                {
                    canBild = false;
                    break;
                }
            }

            if (canBild)
            {
                Console.WriteLine($"Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count <= 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquids)}");
            }

            if (items.Count <= 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine($"Physical items left: {string.Join(", ",items)}");
            }

            foreach (var (key,value) in createdParts.OrderBy(p => p.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }
        }
    }
}
