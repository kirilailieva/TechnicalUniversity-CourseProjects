using System.Text;

namespace Kikk
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, double grade, int age) : base(firstName, lastName, age)
        {
            this.Grade = grade;
        }

        public double Grade { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name:{this.FirstName} {this.LastName} \nGrade:{this.Grade} \nAge:{this.Age}");
            return sb.ToString();
        }
    }
}