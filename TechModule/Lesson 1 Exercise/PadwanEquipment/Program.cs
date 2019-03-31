using System;

namespace PadwanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double lightsaberPrice = lightsabers * Math.Ceiling(students + (students * 0.1));
            double robesPrice = robes * students;
            double beltsPrice = belts * (students - students / 6);
            double neededMoney = lightsaberPrice + robesPrice + beltsPrice;

            if (budget >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(neededMoney - budget):f2}lv more.");
            }
        }
    }
}
