using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dance
{
    class Program
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepsOnDay =((steps / days) / steps);
            stepsOnDay = Math.Ceiling(stepsOnDay * 100);

            double stepsByDancer = stepsOnDay / dancers;

            if (stepsOnDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsByDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsByDancer:f2}% steps to be learned per day. ");
            }
        }
    }
}
