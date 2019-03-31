using System;
using System.Collections.Generic;

namespace ChatLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<string> chat = new List<string>();

            while (command[0] != "end")
            {
                if (command[0] == "Chat")
                {
                    chat.Add(command[1]);
                }
                else if (command[0] == "Delete")
                {
                    if (chat.Contains(command[1]))
                    {
                        chat.Remove(command[1]);
                    }
                }
                else if (command[0] == "Edit")
                {
                    int indexMessage = chat.IndexOf(command[1]);
                    chat[indexMessage] = command[2];

                }
                else if (command[0] == "Pin")
                {
                    chat.Remove(command[1]);
                    chat.Add(command[1]);
                }
                else if (command[0] == "Spam")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        chat.Add(command[i]);
                    }
                }

                command = Console.ReadLine().Split();
            }

            foreach (var text in chat)
            {
                Console.WriteLine(text);
            }
        }
    }
}
