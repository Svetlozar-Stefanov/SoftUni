using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int wordSum = 0;

            for (int i = 0; i <= word.Length - 1; i++)
            {
                char currentLetter = word[i];
                if (currentLetter == 'a')
                {
                    wordSum += 1;
                }
                else if (currentLetter == 'e')
                {
                    wordSum += 2;
                }
                else if (currentLetter == 'i')
                {
                    wordSum += 3;
                }
                else if (currentLetter == 'o')
                {
                    wordSum += 4;
                }
                else if (currentLetter == 'u')
                {
                    wordSum += 5;
                }
            }
            Console.WriteLine(wordSum);
            
        }
    }
}
