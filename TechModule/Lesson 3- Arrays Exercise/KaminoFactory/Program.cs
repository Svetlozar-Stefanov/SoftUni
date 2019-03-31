using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int biggestSubsequence = -1;
            int biggestStartIndex = int.MaxValue;
            int biggestSubSum = -1;
            int[] bestSequence = new int[length];

            string input = Console.ReadLine();
            int bestIndexOfDna = 0;
            int indexDna = 1;

            while (input != "Clone them!")
            {
                int currentSubsequence = 0;
                int currentStartIndex = 0;
                int currentSubSum = 0;
                int[] subsequence = input.Split('!',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int oneCount = 0;

                for (int i = 0; i < length; i++)
                {
                    if (subsequence[i] == 1)
                    {
                        oneCount++;
                        if (oneCount > currentSubsequence)
                        {
                            currentSubsequence = oneCount;
                            currentStartIndex = i - oneCount;
                            currentSubSum = subsequence.Sum();
                        }
                    }
                    else
                    {
                        oneCount = 0;
                    }
                }
                

                if (currentSubsequence > biggestSubsequence)
                {
                    biggestSubsequence = currentSubsequence;
                    biggestStartIndex = currentStartIndex;
                    biggestSubSum = currentSubSum;
                    bestIndexOfDna = indexDna;
                    bestSequence = subsequence;
                }
                else if (currentSubsequence == biggestSubsequence &&
                    currentStartIndex < biggestStartIndex)
                {
                    biggestSubsequence = currentSubsequence;
                    biggestStartIndex = currentStartIndex;
                    biggestSubSum = currentSubSum;
                    bestIndexOfDna = indexDna;
                    bestSequence = subsequence;
                }
                else if (currentSubsequence == biggestSubsequence &&
                    currentStartIndex == biggestStartIndex && currentSubSum > biggestSubSum)
                {
                    biggestSubsequence = currentSubsequence;
                    biggestStartIndex = currentStartIndex;
                    biggestSubSum = currentSubSum;
                    bestIndexOfDna = indexDna;
                    bestSequence = subsequence;
                }

                indexDna++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestIndexOfDna} with sum: {biggestSubSum}.");
            Console.WriteLine(String.Join(" ", bestSequence));

            
        }
    }
}
