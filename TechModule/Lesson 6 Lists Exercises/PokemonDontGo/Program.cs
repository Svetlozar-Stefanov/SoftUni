using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> caughtPokemon = new List<int>();

            while (numberList.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                CatchPokemon(index, numberList, caughtPokemon);
                //Console.WriteLine(String.Join(" ", numberList));
            }
            Console.WriteLine(caughtPokemon.Sum());
        }

        private static void CatchPokemon(int index, List<int> numberList, List<int> caughtPokemon)
        {
            int value = 0;
            if (index < 0)
            {
                caughtPokemon.Add(numberList[0]);
                value = numberList[0];
                numberList[0] = numberList[numberList.Count - 1];
            }
            else if (index >= numberList.Count)
            {
                caughtPokemon.Add(numberList[numberList.Count - 1]);
                value = numberList[numberList.Count - 1];
                numberList[numberList.Count - 1] = numberList[0];
            }
            else
            {
                value = numberList[index];
                caughtPokemon.Add(numberList[index]);
                numberList.RemoveAt(index);
            }
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] <= value)
                {
                    numberList[i] += value;
                }
                else if (numberList[i] > value)
                {
                    numberList[i] -= value;
                }
            }
        }
    }
}
