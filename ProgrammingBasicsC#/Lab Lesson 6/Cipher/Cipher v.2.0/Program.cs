using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher_v._2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("| CAESAR CIPHER V2.0 |");
            Console.WriteLine("----------------------");
            Console.WriteLine("");
            Console.WriteLine("CHOOSE OPERATION:");
            Console.WriteLine("ENCRYPT/DECRYPT");
            try
            {
                string command = Console.ReadLine().ToLower();
                string encryption = "";
                string decryption = "";
                int key = 0;
                while (true)
                {
                    if (command == "encrypt")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("INPUT TEXT:");
                        string message = Console.ReadLine();
                        Console.Write("CHOOSE A KEY: ");
                        key = int.Parse(Console.ReadLine());
                        encryption = Encryption(key, message);
                        Console.WriteLine("");
                        Console.WriteLine("ENCRYPTED TEXT:");
                        Console.WriteLine(encryption);
                        Console.WriteLine("");
                        Console.WriteLine("SHOW||ENCRYPT||DECRYPT||END");
                        command = Console.ReadLine().ToLower();
                        Console.WriteLine("");
                    }
                    else if (command == "show")
                    {
                        decryption = Decryption(encryption, key);
                        Console.WriteLine("DECRYPTED TEXT:");
                        Console.WriteLine(decryption);
                        Console.WriteLine("");
                        Console.WriteLine("ENCRYPT||DECRYPT||END");
                        command = Console.ReadLine().ToLower();
                        Console.WriteLine("");
                    }
                    else if (command == "decrypt")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("INPUT TEXT:");
                        string message = Console.ReadLine();
                        Console.Write("CHOOSE A KEY: ");
                        key = int.Parse(Console.ReadLine());
                        decryption = Decryption(message, key);
                        Console.WriteLine("DECRYPTED TEXT:");
                        Console.WriteLine(decryption);
                        Console.WriteLine("");
                        Console.WriteLine("ENCRYPT||DECRYPT||END");
                        command = Console.ReadLine().ToLower();
                        Console.WriteLine("");
                    }
                    else if (command == "end")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("***************************************");
                        Console.WriteLine("* THANKS FOR USING CAESAR CIPHER V2.0 *");
                        Console.WriteLine("***************************************");
                        Console.WriteLine("");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input!");
                        Console.WriteLine("New input requiered(ENCRYPT||DECRYPT||END):");
                        command = Console.ReadLine().ToLower();
                        
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured!");
                return;
                throw;
            }

        }

        static string Encryption(int key, string message)
        {
            string encryption = "";
            int counter = message.Length;

            for (int i = 0; i < counter; i++)
            {
                if (message[i] >= 65 && message[i] <= 90)
                {
                    int letter = message[i] + key;
                    while (letter > 90)
                    {
                        letter = 64 + (letter - 90);
                    }
                    encryption += (char)letter;
                }
                else if (message[i] >= 97 && message[i] <= 122)
                {
                    int letter = message[i] + key;
                    while (letter > 122)
                    {
                        letter = 96 + (letter - 122);
                    }
                    encryption += (char)letter;
                }
                else
                {
                        encryption += message[i];
                }
            }
            return encryption;
        }

        static string Decryption(string input, int key)
        {
            string decryption = "";

            int counter = input.Length;

            for (int i = 0; i < counter; i++)
            {
                if (input[i] >= 65 && input[i] <= 90)
                {
                    int letter = input[i] - key;
                    while (letter < 65)
                    {
                        letter = 91 - (65 - letter);
                    }
                    decryption += (char)letter;
                }
                else if (input[i] >= 97 && input[i] <= 122)
                {
                    int letter = input[i] - key;
                    while (letter < 97)
                    {
                        letter = 123 - (97 - letter);
                    }
                    decryption += (char)letter;
                }
                else
                {
                    decryption += input[i];
                }
            }
            return decryption;
        }
    }
}
