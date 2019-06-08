using System;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Modifier modifier = new Modifier();

            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            Console.WriteLine(modifier.DateDifferance(DateTime.Parse(date1), DateTime.Parse(date2)));
        }
    }
}
