using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubseqence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] lengthOfSequence = new int[nums.Length];
            int[] previousIndex = new int[nums.Length];
            int maxLength = 0;
            int lastIndex = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                lengthOfSequence[i] = 1;
                previousIndex[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (lengthOfSequence[i] <= lengthOfSequence[j] && nums[i] > nums[j])
                    {
                        lengthOfSequence[i] = 1 + lengthOfSequence[j];
                        previousIndex[i] = j; 
                    }
                }

                if (lengthOfSequence[i] > maxLength)
                {
                    maxLength = lengthOfSequence[i];
                    lastIndex = i;

                }
            }

            var longestSeq = new List<int>();

            for (int i = 0; i < maxLength; i++)
            {
                longestSeq.Add(nums[lastIndex]);
                lastIndex = previousIndex[lastIndex];
            }

            longestSeq.Reverse();

            Console.WriteLine(String.Join(" ",longestSeq.ToArray()));
        }
    }
}
