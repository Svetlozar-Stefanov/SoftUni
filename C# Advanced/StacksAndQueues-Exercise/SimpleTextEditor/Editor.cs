using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Editor
    {
        static void Main(string[] args)
        {
            int numberOfActions = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            Stack<string> history = new Stack<string>();
            history.Push(text.ToString());

            for (int i = 0; i < numberOfActions; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int action = int.Parse(command[0]);

                if (action == 1)
                {
                    string textToAdd = command[1];

                    text.Append(textToAdd);
                    history.Push(text.ToString());
                }
                if (action == 2)
                {
                    int removeCount = int.Parse(command[1]);
                    if (removeCount <= text.Length)
                    {
                        text.Remove(text.Length - removeCount, removeCount);
                        history.Push(text.ToString());
                    }
                }
                if (action == 3)
                {
                    int index = int.Parse(command[1]) - 1;
                    if (0 <= index && index < text.Length)
                    {
                        Console.WriteLine(text[index]);
                    }
                }
                if (action == 4)
                {
                    if (history.Count > 1)
                    {
                        history.Pop();
                        text.Clear();
                        text.Append(history.Peek());
                    }
                    else if (history.Count == 0)
                    {
                        text.Clear();
                        text.Append("");
                    }
                }
            }
        }
    }
}
