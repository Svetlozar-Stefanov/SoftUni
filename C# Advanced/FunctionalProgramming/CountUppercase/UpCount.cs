namespace CountUppercase
{
    using System;
    public class UpCount
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
