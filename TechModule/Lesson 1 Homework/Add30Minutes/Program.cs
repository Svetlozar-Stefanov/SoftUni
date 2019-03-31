using System;


namespace Add30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string timeStr = $"{hours}:{minutes}"; 
            DateTime time = DateTime.Parse(timeStr);
            Console.WriteLine($"{time.AddMinutes(30):H:mm}");
        }
    }
}
