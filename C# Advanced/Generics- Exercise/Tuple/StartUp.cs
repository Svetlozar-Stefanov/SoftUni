using System;
using System.Collections.Generic;

namespace TupleAndThreeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string fullName = $"{input1[0]} {input1[1]}";
            string addres = input1[2];
            string town = input1[3];
            for (int i = 4; i < input1.Length; i++)
            {
                town += " " + input1[i];
            }
            town.Trim();
            Threeuple<string, string,string> threeuple1 = new Threeuple<string, string,string>(fullName, addres,town);
            Console.WriteLine($"{threeuple1.FirstValue} -> {threeuple1.SecondValue} -> {threeuple1.ThirdValue}");

            string[] input2 = Console.ReadLine()
                .Split();
            string name = input2[0];
            double liters = double.Parse(input2[1]);
            bool isDrunk = false;
            if (input2[2] == "not")
            {
                isDrunk = false;
            }
            else if (input2[2] == "drunk")
            {
                isDrunk = true;
            }
            Threeuple<string, double, bool> threeuple2 = new Threeuple<string, double, bool>(name, liters, isDrunk);
            Console.WriteLine($"{threeuple2.FirstValue} -> {threeuple2.SecondValue} -> {threeuple2.ThirdValue}");

            string[] input3 = Console.ReadLine()
                .Split();
            string user = input3[0];
            double dnum = double.Parse(input3[1]);
            string bankName = input3[2];
            for (int i = 3; i < input3.Length; i++)
            {
                bankName += " " + input3[i];
            }
            bankName.Trim();
            Threeuple<string, double,string> threeuple3 = new Threeuple<string, double,string>(user, dnum,bankName);
            Console.WriteLine($"{threeuple3.FirstValue} -> {threeuple3.SecondValue} -> {threeuple3.ThirdValue}");
        }
    }
}
