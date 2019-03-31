using System;

namespace _100SMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string messege = "";

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    messege += " ";
                    continue;
                }
                string numStr = number.ToString();
                int numberOfDigits = numStr.Length;
                int mainDigit = number % 10;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                int letterIndex = (offset + numberOfDigits - 1);
                int letter = 97 + letterIndex;
                messege += (char)letter;
            }
            Console.WriteLine(messege);
        }
    }
}
