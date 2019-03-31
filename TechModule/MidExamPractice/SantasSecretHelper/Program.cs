using System;
using System.Collections.Generic;

namespace SantasSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            List<string> list = new List<string>();
            while (command != "end")
            {
                string decryptedMessage = "";

                for (int i = 0; i < command.Length; i++)
                {
                    decryptedMessage +=(char)(command[i] - key);
                }
                
                string name = "";
                string behvior = "";
                List<char> exceptions =new List<char> {'@', '-', '!', ':', '>'};

                 for (int i = 0; i < decryptedMessage.Length; i++)
                {
                    if (decryptedMessage[i] == '@')
                    {
                        name = "";
                        while (decryptedMessage[i+1] >= 65 && decryptedMessage[i+1] <= 90
                        || decryptedMessage[i+1] >= 97 && decryptedMessage[i+1] <= 122)
                        {
                            name += (char)decryptedMessage[i+1];
                            i++;
                        }
                        if (i - name.Length - 1 >= 0)
                        {
                            if (exceptions.Contains(decryptedMessage[i - name.Length -1]))
                            {
                                name = "";
                            }
                        }
                        if (i+1 < decryptedMessage.Length)
                        {
                            if (exceptions.Contains(decryptedMessage[i+1]))
                            {
                                name = "";
                            }
                        }
                    }

                    if (name.Length > 0)
                    {

                        if (decryptedMessage[i] == '!')
                        {
                            if (i + 2 < decryptedMessage.Length)
                            {
                                if (decryptedMessage[i + 2] == '!')
                                {
                                    behvior += (char)decryptedMessage[i + 1];
                                    if (i - 1 >= 0)
                                    {
                                        if (exceptions.Contains(decryptedMessage[i - 1]))
                                        {
                                            behvior = "";
                                        }
                                    }
                                    if (i + 3 < decryptedMessage.Length)
                                    {
                                        if (exceptions.Contains(decryptedMessage[i + 3]))
                                        {
                                            behvior = "";
                                        }
                                    }
                                }
                                i += 2;
                            }
                        }
                    }
                }

                //Console.WriteLine(name);
                //Console.WriteLine(behvior);

                if (name.Length>0 && behvior.Length >0)
                {
                    if (behvior.ToLower() == "g")
                    {
                        list.Add(name);
                    }
                }

                //Console.WriteLine(string.Join(" ", list));

                command = Console.ReadLine();
            }

            foreach (var kid in list)
            {
                Console.WriteLine(kid);
            }
        }
    }
}
