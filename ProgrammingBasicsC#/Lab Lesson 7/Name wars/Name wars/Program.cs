using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int maxPoints = int.MinValue;
            string winner = "";
            string command = Console.ReadLine();

            while (command != "STOP")
            {
                sum = 0;
                string name = command;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }
                if (sum > maxPoints)
                {
                    maxPoints = sum;
                    winner = name;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winner} - {maxPoints}!");
        }
    }
}
