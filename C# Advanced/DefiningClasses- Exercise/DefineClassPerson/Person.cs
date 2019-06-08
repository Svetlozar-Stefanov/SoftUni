using System;
using System.Collections.Generic;
using System.Text;

namespace DefineClassPerson
{
    public class Person
    {
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ChangeValues(string name,int age)
        {
            Name = name;
            Age = age;
        }
    }
}
