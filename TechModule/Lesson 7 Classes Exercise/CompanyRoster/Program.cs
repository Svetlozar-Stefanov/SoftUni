using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());
            if (numberOfEmployees <= 0)
            {
                return;
            }
            List<Employee> listEmployees = new List<Employee>();
            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] input = Console.ReadLine().Split();
                Employee currentEmployee = new Employee();

                currentEmployee.Name = input[0];
                currentEmployee.Salary = decimal.Parse(input[1]);
                currentEmployee.Department = input[2];

                listEmployees.Add(currentEmployee);
            }

            List<Employee> bestDepartment = new List<Employee>();
            decimal bestAvg = int.MinValue;
            for (int i = 0; i < listEmployees.Count; i++)
            {
                List<Employee> currentDepartment = new List<Employee>();

                currentDepartment = listEmployees.Where(x => x.Department == listEmployees[i].Department).ToList();
                listEmployees.RemoveAll(x => x.Department == currentDepartment[0].Department);
                i = -1;
                decimal sum = 0;
                foreach (var person in currentDepartment)
                {
                    sum += person.Salary;
                }
                decimal currAvg = sum / currentDepartment.Count;

                if (currAvg > bestAvg)
                {
                    bestAvg = currAvg;
                    bestDepartment.Clear();
                    foreach (var person in currentDepartment)
                    {
                        bestDepartment.Add(person);
                    }
                }
            }

            bestDepartment = bestDepartment.OrderByDescending(x => x.Salary).ToList();
            Console.WriteLine($"Highest Average Salary: {bestDepartment[0].Department}");
            foreach (var person in bestDepartment)
            {
                Console.WriteLine($"{person.Name} {person.Salary:f2}");
            }
        }
    }

    class Employee
    {
        public string Name;
        public decimal Salary;
        public string Department;

    }
}
