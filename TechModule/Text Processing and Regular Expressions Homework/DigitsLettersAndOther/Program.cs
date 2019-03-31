using System;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string numbers = "";
            string letters = "";
            string other = "";

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else if (char.IsDigit(symbol))
                {
                    numbers += symbol;
                }
                else
                {
                    other += symbol;
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
