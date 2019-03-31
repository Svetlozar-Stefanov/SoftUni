using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int count = GetVowelsCount(input.ToLower());
            Console.WriteLine(count);
        }

        private static int GetVowelsCount(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' ||
                    input[i] == 'e' || 
                    input[i] == 'i' || 
                    input[i] == 'o' || 
                    input[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
