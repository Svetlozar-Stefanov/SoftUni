using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> listStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                Student student = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));
                listStudents.Add(student);
            }

            listStudents = listStudents.OrderByDescending(x => x.Grade).ToList();

            foreach (var person in listStudents)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    class Student
    {
        public Student(string firstName, string secondName, double grade)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grade = grade;
        }
        public string FirstName;
        public string SecondName;
        public double Grade;

        public override string ToString()
        {
            return $"{FirstName} {SecondName}: {Grade:f2}";
        }
    }
}
