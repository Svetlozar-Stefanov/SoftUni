using System;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] strArray = new int[numberOfStrings];
            
            for (int i = 0; i < numberOfStrings; i++)
            {
                string word = Console.ReadLine();
                int encryption = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    bool vowel = "aeiouAEIOU".IndexOf(word[j]) >= 0;
                    if (vowel)
                    {
                        encryption += word[j] * word.Length;
                    }
                    else
                    {
                        encryption += word[j] / word.Length;
                    }
                }
                strArray[i] = encryption;
            }

            Array.Sort(strArray);

            foreach (var code in strArray)
            {
                Console.WriteLine(code);
            }
        }
    }
}
