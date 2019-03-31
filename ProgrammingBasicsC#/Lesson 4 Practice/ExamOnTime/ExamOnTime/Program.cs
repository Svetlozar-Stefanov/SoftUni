using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOnTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hoursArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int examTimeInMin = hoursExam * 60 + minutesExam;
            int studentsTimeInMin = hoursArrival * 60 + minutesArrival;

            int minutesDifference = studentsTimeInMin - examTimeInMin;

            if (minutesDifference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (minutesDifference <= 0)
            {
                Console.WriteLine("On time");
            }
            else 
            {
                Console.WriteLine("Late");
            }

            int hours = Math.Abs(minutesDifference / 60);
            int minutes = Math.Abs(minutesDifference % 60);

            if (hours > 0)
            {
                if (minutes < 10)
                {
                    Console.Write(hours + ":0" + minutes + "hours");                    
                }
                else
                {
                    Console.Write(hours + ":" + minutes + "hours");
                }
            }
            else
            {
                Console.WriteLine(minutes + " minutes");
            }
            if (minutesDifference < 0)
            {
                Console.WriteLine(" before the start");
            }
            else
            {
                Console.WriteLine(" after the start");
            }
        }
    }
}
