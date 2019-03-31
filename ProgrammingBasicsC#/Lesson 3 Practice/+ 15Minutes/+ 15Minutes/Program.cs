using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int fromHoursToMin = hour * 60;
            int totalMinutes = fromHoursToMin + minutes + 15;

            TimeSpan result = TimeSpan.FromMinutes(totalMinutes);
            Console.WriteLine($"{result:h\\:mm}");
        }
    }
}
