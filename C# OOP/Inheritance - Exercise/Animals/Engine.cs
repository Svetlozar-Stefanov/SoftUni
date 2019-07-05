using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Engine
    {
        private string name;

        private int age;

        private string gender;

        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "Beast!")
            {
                string[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (info.Length < 2 || !int.TryParse(info[1], out int num) || num < 0)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                name = info[0];
                age = num;
                if (info.Length == 3)
                {
                    gender = info[2];
                }

                switch (input)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(dog);
                        break;
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(cat);
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(frog);
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine(kitten);
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        Console.WriteLine(tomcat);
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
