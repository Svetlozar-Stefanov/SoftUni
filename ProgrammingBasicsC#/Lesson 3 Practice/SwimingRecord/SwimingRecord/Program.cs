using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double estimatedTime = distance * time;
            double waterResistance =Math.Floor(distance / 15) * 12.5;
            double ivanchosTime = estimatedTime + waterResistance;
            if (ivanchosTime > record)
            {
                double neededTime = ivanchosTime - record;
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");
            }
            else if(record > ivanchosTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchosTime:f2} seconds.");
            }
        }
    }
}
