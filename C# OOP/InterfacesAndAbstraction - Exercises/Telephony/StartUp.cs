using System;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split(" ");

            Smartphone smartphone = new Smartphone();
            foreach (var number in numbers)
            {
                try
                {
                    smartphone.CallNumber(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string[] adresses = Console.ReadLine()
                .Split(" ");

            foreach (var adress in adresses)
            {
                try
                {
                    smartphone.Surf(adress);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
