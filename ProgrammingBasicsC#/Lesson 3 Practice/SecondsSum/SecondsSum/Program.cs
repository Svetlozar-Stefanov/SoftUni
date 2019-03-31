using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstTime = double.Parse(Console.ReadLine());
            double secondTime = double.Parse(Console.ReadLine());
            double thirdTime = double.Parse(Console.ReadLine());

            double secondsSum = firstTime + secondTime + thirdTime;
           

            if (secondsSum >= 0 & secondsSum <= 59)
            {
                if (secondsSum < 10)
                {
                    
                    Console.WriteLine($"0:0{secondsSum}");
                }
                else
                Console.WriteLine($"0:{secondsSum}");
            }
            else if (secondsSum >= 60 & secondsSum <= 119)
            {
                secondsSum = secondsSum - 60;
                if (secondsSum < 10)
                {
                    
                    Console.WriteLine($"1:0{secondsSum}");
                }
                else
                Console.WriteLine($"1:{secondsSum}");
            }
            else if (secondsSum >= 120 & secondsSum <= 179)
            {
                secondsSum = secondsSum - 120;
                if (secondsSum < 10)
                {
                    
                    Console.WriteLine($"2:0{secondsSum}");
                }
                else
                Console.WriteLine($"2:{secondsSum}");
            }
        }
    }
}
