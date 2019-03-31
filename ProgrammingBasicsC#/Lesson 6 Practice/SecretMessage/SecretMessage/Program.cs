using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            string decrypt = "";

            Console.WriteLine("--------------------------------");
            Console.WriteLine("| TOP SECRET MESSAGE ENCRYPTER |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Enter text here:");
            string text = Console.ReadLine();
            int counter = text.Length;
            Console.Write("Enter a key(number): ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Encrypt/Decrypt");
            string command = Console.ReadLine().ToLower();
            Console.WriteLine("");

            while (command != "end")
            {
                if (command == "encrypt")
                {
                    for (int i = 0; i < counter; i++)
                    {
                        int letter = text[i] + key;
                        output += (char)letter;
                    }

                    Console.WriteLine("Encrypted text is:");
                    Console.WriteLine(output);
                    Console.WriteLine("");
                    Console.WriteLine("How do you wish to proceed? Choose command:");
                    Console.WriteLine("NewEn || NewDe || CurrDe || END ");
                    command = Console.ReadLine().ToLower();
                    Console.WriteLine("");

                }

                if (command == "currde")
                {
                    decrypt = "";
                    for (int i = 0; i < counter; i++)
                    {
                        int letter = output[i] - key;
                        decrypt += (char)letter;
                    }
                    Console.WriteLine("Decrypted text is:");
                    Console.WriteLine(decrypt);
                    Console.WriteLine("");
                    Console.WriteLine("NewEn || NewDe || END");
                    command = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }

                if (command == "newen")
                {
                    output = "";
                    Console.WriteLine("Enter text here:");
                    text = Console.ReadLine();
                    counter = text.Length;
                    Console.Write("Enter a key(number): ");
                    key = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    for (int i = 0; i < counter; i++)
                    {
                        int letter = text[i] + key;
                        output += (char)letter;
                    }
                    Console.WriteLine("Encrypted text is:");
                    Console.WriteLine(output);
                    Console.WriteLine("");
                    Console.WriteLine("How do you wish to proceed? Choose command:");
                    Console.WriteLine("NewEn || NewDe || CurrDe || END ");
                    command = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }

                if (command == "decrypt")
                {
                    decrypt = "";
                    for (int i = 0; i < counter; i++)
                    {
                        int letter = text[i] - key;
                        decrypt += (char)letter;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Decrypted text is:");
                    Console.WriteLine(decrypt);
                    Console.WriteLine("");
                    Console.WriteLine("NewDe || NewEn || END");
                    command = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }

                if (command == "newde")
                {
                    decrypt = "";
                    Console.WriteLine("Enter text here:");
                    text = Console.ReadLine();
                    counter = text.Length;
                    Console.Write("Enter a key(number): ");
                    key = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    for (int i = 0; i < counter; i++)
                    {
                        int letter = text[i] - key;
                        decrypt += (char)letter;
                    }
                    Console.WriteLine("Decrypted text is:");
                    Console.WriteLine(decrypt);
                    Console.WriteLine("");
                    Console.WriteLine("NewDe || NewEn || END");
                    command = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }
               
            }
            if (command == "end")
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("| THANKS FOR USING MY PROGRAM |");
                Console.WriteLine("-------------------------------");

                return;
            }
           







        }
    }
}
