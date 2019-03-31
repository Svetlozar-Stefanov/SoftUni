using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int actions = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < actions; i++)
            {
                string[] command = Console.ReadLine().Split();
                string username = command[1];

                if (command[0] == "register")
                {
                    string licensePlateNumber = command[2];
                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        parking[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (!parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var users in parking)
            {
                Console.WriteLine($"{users.Key} => {users.Value}");
            }
        }
    }
}
