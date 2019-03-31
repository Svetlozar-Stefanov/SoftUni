using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftuniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> primalSchedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                List<string> command = input.Split(":").ToList();
                string action = command[0].ToLower();
                if (action == "add")
                {
                    string lesson = command[1];
                    if (!primalSchedule.Contains(lesson))
                    {
                        primalSchedule.Add(lesson);
                    }
                }
                else if (action == "insert")
                {
                    string lesson = command[1];
                    int index = int.Parse(command[2]);

                    if (!primalSchedule.Contains(lesson))
                    {
                        primalSchedule.Insert(index, lesson);
                    }
                }
                else if (action == "remove")
                {
                    string lesson = command[1];
                    string exercise = $"{lesson}-Exercise";
                    if (primalSchedule.Contains(lesson))
                    {
                        primalSchedule.Remove(lesson);
                    }
                    if (primalSchedule.Contains(exercise))
                    {
                        primalSchedule.Remove(exercise);
                    }
                }
                else if (action == "swap")
                {
                    string lesson1 = command[1];
                    string lesson2 = command[2];

                    if (primalSchedule.Contains(lesson1) && primalSchedule.Contains(lesson2))
                    {
                        int indexLesson1 = primalSchedule.IndexOf(lesson1);
                        int indexLesson2 = primalSchedule.IndexOf(lesson2);

                        string temp = primalSchedule[indexLesson1];
                        primalSchedule[indexLesson1] = primalSchedule[indexLesson2];
                        primalSchedule[indexLesson2] = temp;

                        string exercise1 = $"{lesson1}-Exercise";
                        if (primalSchedule.Contains(exercise1))
                        {
                            primalSchedule.Remove(exercise1);
                            primalSchedule.Insert(indexLesson2 + 1, exercise1);
                        }

                        string exercise2 = $"{lesson2}-Exercise";
                        if (primalSchedule.Contains(exercise2))
                        {
                            primalSchedule.Remove(exercise2);
                            primalSchedule.Insert(indexLesson1 + 1, exercise2);
                        }
                    }
                }
                else if (action == "exercise")
                {
                    string lesson = $"{command[1]}-Exercise";
                    if (primalSchedule.Contains(command[1]) && !primalSchedule.Contains(lesson))
                    {
                        primalSchedule.Insert(primalSchedule.IndexOf(command[1]) + 1, lesson);
                    }
                    else if (!primalSchedule.Contains(command[1]) && !primalSchedule.Contains(lesson))
                    {
                        primalSchedule.Add(command[1]);
                        primalSchedule.Add(lesson);
                    }

                }
                //Console.WriteLine(String.Join(" ", primalSchedule));
                input = Console.ReadLine();
            }

            for (int i = 0; i < primalSchedule.Count; i++)
            {
                Console.WriteLine($"{i+1}.{primalSchedule[i]}");
            }
        }
    }
}
