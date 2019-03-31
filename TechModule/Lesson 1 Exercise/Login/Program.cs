using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = "";
            int attempts = 1;

            for (int i = user.Length-1; i >= 0; i--)
            {
                password += user[i];
            }

            while (true)
            {
                string login = Console.ReadLine();

                if (password == login)
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
                else
                {
                    if (attempts < 4)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        attempts++;
                    }
                    else
                    {
                        Console.WriteLine($"User {user} blocked!");
                        return;
                    }
                    
                }
            }
        }
    }
}
