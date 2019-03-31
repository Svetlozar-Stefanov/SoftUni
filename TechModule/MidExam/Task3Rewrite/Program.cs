using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3Rewrite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> message = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split();
            while (command[0] != "Stop")
            {
                if (command[0] == "Delete")
                {
                    int index = int.Parse(command[1]) + 1;
                    if (index >= 0 && index < message.Count)
                    {
                        message.RemoveAt(index);
                    }
                }
                else if (command[0] == "Swap")
                {
                    string word1 = command[1];
                    string word2 = command[2];
                    if (message.Contains(word1) && message.Contains(word2))
                    {
                        int index1Word = message.IndexOf(word1);
                        int index2Word = message.IndexOf(word2);

                        string tempWord = word1;
                        message[index1Word] = message[index2Word];
                        message[index2Word] = tempWord;
                    }
                }
                else if (command[0] == "Put")
                {
                    string word = command[1];
                    int index = int.Parse(command[2]) - 1;
                    if (index >= 0 && index < message.Count)
                    {
                        message.Insert(index, word);
                    }
                }
                else if (command[0] == "Sort")
                {
                    message.Sort();
                    message.Reverse();
                }
            }
        }
    }
}
