using System;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (input.ToLower() == "pop")
                {
                    stack.Pop();
                }
                if (input.Contains("Push"))
                {
                    string[] info = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 1; i < info.Length; i++)
                    {
                        stack.Push(int.Parse(info[i]));
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 1; i <= 2; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
