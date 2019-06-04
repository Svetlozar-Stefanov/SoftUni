namespace ActionPoint
{
    using System;
    public class Point
    {
        public static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Print(names);
        }

        public static Action<string[]> Print = n =>
        {
            foreach (var item in n)
            {
                Console.WriteLine(item);
            }
        };

    }
}
