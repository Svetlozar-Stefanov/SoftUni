using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> message = Console.ReadLine().Split(' ').ToList();
            string[] actions = Console.ReadLine().Split(' ').ToArray();
            while (actions[0].ToLower() != "stop")
            {
                if (actions[0].ToLower() == "delete")
                {
                    int index = int.Parse(actions[1]);
                    if (index + 1 >= 0 && index + 1 < message.Count)
                    {
                        message.RemoveAt(index + 1);
                    }
                }
                if (actions[0].ToLower() == "swap")
                {
                    string word1 = actions[1];
                    string word2 = actions[2];

                    if (message.Contains(word1) && message.Contains(word2))
                    {
                        int indexWord1 = message.IndexOf(word1);
                        int indexWord2 = message.IndexOf(word2);

                        string tempWord = word1;
                        message[indexWord1] = message[indexWord2];
                        message[indexWord2] = tempWord;
                    }
                }
                if (actions[0].ToLower() == "put")
                {
                    string word = actions[1];
                    int index = int.Parse(actions[2]);
                    if (index - 1 >= 0 && index - 1 <= message.Count)
                    {
                        if (index - 1 == message.Count)
                        {
                            message.Add("");
                        }
                        message.Insert(index - 1, word);
                    }

                }
                if (actions[0].ToLower() == "sort")
                {
                    message.Sort();
                    message.Reverse();
                }
                if (actions[0].ToLower() == "replace")
                {
                    string word1 = actions[1];
                    string word2 = actions[2];

                    if (message.Contains(word2))
                    {
                        int indexWord2 = message.IndexOf(word2);
                        message[indexWord2] = word1;
                    }
                }

                actions = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(String.Join(" ", message));
        }
    }
}
