using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] keys = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string firstSubstring = keys[0];
            string secondSubstring = keys[1];

            Regex regex = new Regex(@"^[d-z{}|#]+$");

            if (regex.IsMatch(input))
            {
                StringBuilder decryption = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    char currentLetter = input[i];
                    decryption.Append((char)(currentLetter - 3));
                }

                string textToEdit = decryption.ToString();
                textToEdit = textToEdit.Replace(firstSubstring, secondSubstring);
                Console.WriteLine(textToEdit);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
