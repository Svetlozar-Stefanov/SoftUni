namespace KnightsOfHonor
{
    using System;
    public class Knight
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
                Console.WriteLine($"Sir {item}");
            }
        };
    }
}
