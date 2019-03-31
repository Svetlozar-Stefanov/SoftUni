using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("| CAESAR CIPHER |");
            Console.WriteLine("-----------------");
            Console.WriteLine("");

            Console.Write("START TO CONTINUE: ");
            string command = Console.ReadLine();

            string encryption = "";
            string decryption = "";

            Console.WriteLine("");
            Console.WriteLine("ENCRYPT/DECRYPT");
            command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                if (command == "encrypt")
                {
                    encryption = "";
                    Console.WriteLine("");
                    Console.WriteLine("INPUT TEXT:");
                    string message = Console.ReadLine().ToUpper();
                    int counter = message.Length;
                    Console.Write("CHOOSE A KEY: ");
                    int key = int.Parse(Console.ReadLine());

                    for (int i = 0; i < counter; i++)
                    {
                        if (message[i] == ' ')
                        {
                            encryption += " ";
                            continue;
                        }
                        int letter = message[i] + key;
                        while (letter > 90)
                        {
                            letter = 64 + (letter - 90);
                        }
                        encryption += (char)letter;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("ENCRYPTED TEXT:");
                    Console.WriteLine(encryption);
                    Console.WriteLine("");
                    Console.WriteLine("ENCRYPT||CURRDEC||DECRYPT||END");
                    command = Console.ReadLine().ToLower();
                    Console.WriteLine("");

                    if (command == "currdec")
                    {
                        decryption = "";
                        for (int i = 0; i < counter; i++)
                        {
                            if (encryption[i] == ' ')
                            {
                                decryption += " ";
                                continue;
                            }
                            int letter = encryption[i] - key;
                            while (letter < 65)
                            {
                                letter = 91 - (65 - letter);
                            }
                            decryption += (char)letter;
                        }
                        Console.WriteLine("DECRYPTED TEXT:");
                        Console.WriteLine(decryption);
                        Console.WriteLine("");
                        Console.WriteLine("ENCRYPT||DECRYPT||END");
                        command = Console.ReadLine().ToLower();
                        Console.WriteLine("");
                    }
                }
                if (command == "decrypt")
                {
                    decryption = "";
                    Console.WriteLine("");
                    Console.WriteLine("INPUT TEXT:");
                    string message = Console.ReadLine().ToUpper();
                    int counter = message.Length;
                    Console.Write("CHOOSE A KEY: ");
                    int key = int.Parse(Console.ReadLine());

                    for (int i = 0; i < counter; i++)
                    {
                        if (encryption[i] == ' ')
                        {
                            decryption += " ";
                            continue;
                        }
                        int letter = message[i] - key;
                        while (letter < 65)
                        {
                            letter = 91 - (65 - letter);
                        }
                        decryption += (char)letter;
                    }
                    Console.WriteLine("DECRYPTED TEXT:");
                    Console.WriteLine(decryption);
                    Console.WriteLine("");
                    Console.WriteLine("ENCRYPT||DECRYPT||END");
                    command = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("**********************************");
            Console.WriteLine("* THANKS FOR USING CAESAR CIPHER *");
            Console.WriteLine("**********************************");
            Console.WriteLine("");
        }
    }
}
