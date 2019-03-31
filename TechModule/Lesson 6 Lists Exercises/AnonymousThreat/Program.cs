using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    Merge(startIndex,endIndex,data);
                    //Console.WriteLine(String.Join(" ", data));

                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);

                    Divide(index,partitions,data);
                    //Console.WriteLine(String.Join(" ", data));

                }

                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(String.Join(" ", data));
        }

        private static void Divide(int index, int partitions, List<string> data)
        {
            while (index > data.Count)
            {
                index--;
            }
            string textToDivide = data[index];
            List<string> result = new List<string>();
            while (partitions > textToDivide.Length)
            {
                partitions--;
            }
            int lengthOfSeparatedText = textToDivide.Length / partitions;
            
            int j = 0;
            int tempLength = lengthOfSeparatedText;
            for (int i = 0; i < partitions; i++)
            {
                string split = "";
                for (int k = j ; k < tempLength; k++)
                {
                    split += textToDivide[k];
                }
                j = tempLength;
                tempLength += lengthOfSeparatedText;
                result.Add(split);
            }
            while (true)
            {
                try
                {
                    result[result.Count - 1] += textToDivide[j];
                    j++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            for (int i = result.Count - 1; i >= 0; i--)
            {
                data.Insert(index, result[i]);
            }
            data.RemoveAt(index + result.Count);
        }

        private static void Merge(int startIndex, int endIndex, List<string> data)
        {
            while (startIndex < 0)
            {
                startIndex++;
            }
            while (endIndex >= data.Count)
            {
                endIndex--;
            }
            while (startIndex > endIndex)
            {
                startIndex--;
            }
            string merge = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                merge += data[i];
            }
            data[endIndex] = merge;
            for (int i = startIndex; i < endIndex; i++)
            {
                data.RemoveAt(startIndex);
            }
        }
    }
}
