using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                Console.WriteLine(Palindrome(input));

                input = Console.ReadLine().ToLower();
            }
        }

        private static string Palindrome(string input)
        {
            char[] inputToChar = input.ToCharArray();
            Array.Reverse(inputToChar);
            string reversedInput = String.Join("",inputToChar);

            if (input == reversedInput)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
    }
}
