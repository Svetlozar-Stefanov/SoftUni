namespace NamesFilter
{
    using System;
    public class Filter
    {
        public static void Main(string[] args)
        {
            int desiredLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            FilterAndPrint(desiredLength, names);
        }

        public static Action<int, string[]> FilterAndPrint = (len, arr) =>
        {
            foreach (var word in arr)
            {
                if (word.Length <= len)
                {
                    Console.WriteLine(word);
                }
            }
        };
    }
}
