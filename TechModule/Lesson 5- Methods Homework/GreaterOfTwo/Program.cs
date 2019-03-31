using System;

namespace GreaterOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            PrintGreater(type, input1, input2);
            
        }

        private static void PrintGreater(string type, string input1, string input2)
        {
            if (type == "int")
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);
                int greater = GetMax(num1, num2);
                Console.WriteLine(greater);
            }
            else if (type == "char")
            {
                char ch1 = char.Parse(input1);
                char ch2 = char.Parse(input2);
                char greater = GetMax(ch1, ch2);
                Console.WriteLine(greater);
            }
            else if (type == "string")
            {
                string str1 = input1;
                string str2 = input2;
                string greater = GetMax(str1, str2);
                Console.WriteLine(greater);
            }
        }
        private static string GetMax(string str1,string str2)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] > str2[i])
                {
                    return str1;
                }
                else
                {
                    return str2;
                }
            }
            return "";
        }

        private static char GetMax(char ch1, char ch2)
        {
            if (ch1 > ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
        }

        private static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
    }
}
