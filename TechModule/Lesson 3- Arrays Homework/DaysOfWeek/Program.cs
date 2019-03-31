using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] {"Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"};

            int dayOfWeek = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(days[dayOfWeek-1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
        }
    }
}
