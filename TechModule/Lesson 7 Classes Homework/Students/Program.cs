using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Student> students = new List<Student>();

            while (command[0] != "end")
            {
                if (StudentExisting(students, command[0], command[1]))
                {
                    Student student = GetStudent(students, command[0], command[1]);
                    student.Age = int.Parse(command[2]);
                    student.Hometown = command[3];
                }
                else
                {
                    students.Add(new Student(command[0], command[1], int.Parse(command[2]), command[3]));
                }

                command = Console.ReadLine().Split();
            }

            string cityFilter = Console.ReadLine();

            foreach (var student in students)
            {
                student.CheckHometown(cityFilter);
            }
        }

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        private static bool StudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Hometown;

        public Student(string firstName, string lastName, int age, string hometown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hometown = hometown;
        }

        public void CheckHometown(string cityFilter)
        {
            if (Hometown == cityFilter)
            {
                Console.WriteLine($"{FirstName} {LastName} is {Age} years old.");
            }
        }
    }
}
