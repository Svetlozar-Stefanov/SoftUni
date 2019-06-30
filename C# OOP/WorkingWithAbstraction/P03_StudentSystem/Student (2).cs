namespace P03_StudentSystem
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
    }
}