using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] input = Console.ReadLine().Split();
            while (input[0] != "end")
            {
                if (input[0] == "exchange")
                {
                    int exchangeIndex = int.Parse(input[1]);
                    ExchangeArray(exchangeIndex, startArray);
                }
                else if (input[0] == "max" || input[0] == "min" )
                {
                    string additionalInfo = input[1];
                    if (input[0] == "max")
                    {
                        if (additionalInfo == "even")
                        {
                            PrintMaxEvenIndex(startArray);
                        }
                        else if (additionalInfo == "odd")
                        {
                            PrintMaxOddIndex(startArray);
                        }
                    }
                    else if (input[0] == "min")
                    {
                        if (additionalInfo == "even")
                        {
                            PrintMinEvenIndex(startArray);
                        }
                        else if (additionalInfo == "odd")
                        {
                            PrintMinOddIndex(startArray);
                        }
                    }
                }
                
                else
                {
                    int count = int.Parse(input[1]);
                    if (count > 0 && count <= startArray.Length)
                    {
                        string additionalInfo = input[2];
                        if (input[0] == "first")
                        {
                            if (additionalInfo == "even")
                            {
                                PrintFirstEven(startArray, count);
                            }
                            else if (additionalInfo == "odd")
                            {
                                PrintFirstOdd(startArray, count);
                            }
                        }

                        else if (input[0] == "last")
                        {
                            if (additionalInfo == "even")
                            {
                                PrintLastEven(startArray, count);
                            }
                            else if (additionalInfo == "odd")
                            {
                                PrintLastOdd(startArray, count);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
                        
                
                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{String.Join(", ",startArray)}]");
        }

        private static void PrintLastOdd(int[] startArray, int count)
        {
            int oddNumCount = 0;
            List<int> result = new List<int>();
            for (int i = startArray.Length - 1; i >= 0; i--)
            {
                int number = startArray[i];
                if (number % 2 != 0)
                {
                    result.Add(number);
                    oddNumCount++;
                    if (oddNumCount >= count)
                    {
                        break;
                    }
                }
            }
            result.Reverse();
            Console.WriteLine($"[{String.Join(", ", result)}]");
        }

        private static void PrintLastEven(int[] startArray, int count)
        {
            int evenNumCount = 0;
            List<int> result = new List<int>();
            for (int i = startArray.Length - 1; i >= 0; i--)
            {
                int number = startArray[i];
                if (number % 2 == 0)
                {
                    result.Add(number);
                    evenNumCount++;
                    if (evenNumCount >= count)
                    {
                        break;
                    }
                }
            }
            result.Reverse();
            Console.WriteLine($"[{String.Join(", ", result)}]");
        }

        private static void PrintFirstOdd(int[] startArray, int count)
        {
            int oddNumCount = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < startArray.Length; i++)
            {
                int number = startArray[i];
                if (number % 2 != 0)
                {
                    result.Add(number);
                    oddNumCount++;
                    if (oddNumCount >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{String.Join(", ", result)}]");
        }

        private static void PrintFirstEven(int[] startArray, int count)
        {
            int evenNumCount = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < startArray.Length; i++)
            {
                int number = startArray[i];
                if (number % 2 == 0)
                {
                    result.Add(number);
                    evenNumCount++;
                    if (evenNumCount >= count)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"[{String.Join(", ", result)}]");
        }

        private static void PrintNoMatchesException()
        {
            Console.WriteLine("No matches");
        }

        private static void PrintMinOddIndex(int[] startArray)
        {
            int minOdd = int.MaxValue;
            int index = -1;
            for (int i = 0; i < startArray.Length; i++)
            {
                int number = startArray[i];
                if (number % 2 != 0)
                {
                    if (number <= minOdd)
                    {
                        minOdd = number;
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                PrintNoMatchesException();
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static void PrintMinEvenIndex(int[] startArray)
        {
            int minEven = int.MaxValue;
            int index = -1;
            for (int i = 0; i < startArray.Length; i++)
            {
                int number = startArray[i];
                if (number % 2 == 0)
                {
                    if (number <= minEven)
                    {
                        minEven = number;
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                PrintNoMatchesException();
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static void PrintMaxOddIndex(int[] startArray)
        {
            int maxOdd = int.MinValue;
            int index = -1;
            for (int i = 0; i < startArray.Length; i++)
            {
                int number = startArray[i];
                if (number % 2 != 0)
                {
                    if (number >= maxOdd)
                    {
                        maxOdd = number;
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                PrintNoMatchesException();
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static void PrintMaxEvenIndex(int[] startArray)
        {
            int maxEven = int.MinValue;
            int index = -1;
            for (int i = 0; i < startArray.Length; i++)
            {
                int number = startArray[i];
                if (number % 2 == 0)
                {
                    if (number >= maxEven)
                    {
                        maxEven = number;
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                PrintNoMatchesException();
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static void ExchangeArray(int exchangeIndex, int[] startArray)
        {
            if (exchangeIndex >= 0 && exchangeIndex < startArray.Length)
            {
                for (int i = 0; i <= exchangeIndex; i++)
                {
                    for (int j = 0; j < startArray.Length - 1; j++)
                    {
                        int temp = startArray[j];
                        startArray[j] = startArray[j + 1];
                        startArray[j + 1] = temp;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
    }
}
