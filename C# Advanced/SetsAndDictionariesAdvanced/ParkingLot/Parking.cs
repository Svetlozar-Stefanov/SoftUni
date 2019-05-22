namespace ParkingLot
{
    using System;
    using System.Collections.Generic;

    public class Parking
    {
        public static void Main(string[] args)
        {
            HashSet<string> carLots = new HashSet<string>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0]?.ToLower() != "end")
            {
                string direction = input[0];
                string code = input[1];

                if (direction.ToLower() == "in")
                {
                    carLots.Add(code);
                }
                if (direction.ToLower() == "out")
                {
                    carLots.Remove(code);
                }
                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carLots.Count > 0)
            {
                Console.WriteLine(String.Join("\n",carLots));
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}
