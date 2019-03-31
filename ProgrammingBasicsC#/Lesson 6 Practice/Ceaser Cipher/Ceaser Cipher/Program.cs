using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceaser_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            int counter = message.Length;
            int key = int.Parse(Console.ReadLine());
            string encryption = "";
            string decryption = "";

            for (int i = 0; i < counter; i++)
            {
                int letter = message[i] + key;
                while(letter > 90)
                {
                    letter = 64 + (letter - 90);
                }
                encryption += (char)letter;
            }
            Console.WriteLine(encryption);

            for (int i = 0; i < counter; i++)
            {
                int letter = encryption[i] - key;
                while (letter < 65)
                {
                    letter = 90 - (letter - 64);
                }
                decryption += (char)letter;
            }
            Console.WriteLine(decryption);
        }
    }
}
