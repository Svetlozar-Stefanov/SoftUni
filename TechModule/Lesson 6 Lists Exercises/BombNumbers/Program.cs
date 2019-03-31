using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] properties = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = properties[0];
            int power = properties[1];

            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] == bombNumber)
                {
                    int tempPower = power;
                    for (int j = i - tempPower; j <= i + tempPower; j++)
                    {
                        try
                        {
                            numList.RemoveAt(i - tempPower);
                        }
                        catch (Exception)
                        {
                            tempPower--;
                            j--;
                        }
                    }
                    i = -1;
                    
                }
            }
            Console.WriteLine(numList.Sum());
        }
    }
}
