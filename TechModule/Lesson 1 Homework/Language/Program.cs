using System;

namespace Language
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country.ToLower())
            {
                case "usa":
                case "england":
                    Console.WriteLine("English");break;
                case "spain":
                case "argentina":
                case "mexico":
                    Console.WriteLine("Spanish"); break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
