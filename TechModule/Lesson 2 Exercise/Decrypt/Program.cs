using System;

namespace Decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string decryptedMessages = "";

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                decryptedMessages += (char)(letter + key);
            }
            Console.WriteLine(decryptedMessages);
        }
    }
}
