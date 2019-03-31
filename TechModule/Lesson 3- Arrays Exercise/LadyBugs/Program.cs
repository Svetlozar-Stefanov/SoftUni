using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugPosition = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] ladybugs = new int[fieldSize];

            for (int i = 0; i < ladybugPosition.Length; i++)
            {
                if (ladybugPosition[i] >= 0 && ladybugPosition[i] < fieldSize && fieldSize != 0)
                {
                    ladybugs[ladybugPosition[i]] = 1;
                }
            }
            //Console.WriteLine(String.Join(" ",ladybugs));
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputInfo = input.Split();

                int currentBugIndex = int.Parse(inputInfo[0]);
                string direction = inputInfo[1];
                int steps = int.Parse(inputInfo[2]);

                if (currentBugIndex >= 0 && currentBugIndex < fieldSize && ladybugs[currentBugIndex] == 1 && steps != 0)
                {
                    try
                    {
                        if (direction == "right" || (direction == "left" && steps < 0))
                        {
                            
                            if (direction == "left" && steps < 0)
                            {
                                steps = Math.Abs(steps);
                            }
                            while (ladybugs[currentBugIndex + steps] != 0)
                            {
                                steps += steps;
                            }
                            ladybugs[currentBugIndex] = 0;
                            ladybugs[currentBugIndex + steps] = 1;
                        }
                        else if (direction == "left")
                        {
                            while (ladybugs[currentBugIndex - steps] != 0)
                            {
                                steps += steps;
                            }
                            ladybugs[currentBugIndex] = 0;
                            ladybugs[currentBugIndex - steps] = 1;
                        }
                    }
                    catch (Exception)
                    {
                        ladybugs[currentBugIndex] = 0;
                    }
                }
                //Console.WriteLine(String.Join(" ", ladybugs));
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", ladybugs));
        }
    }
}
