
using System.Text;

namespace Kikk
{
    public class Person : IPerson
    {
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name:{this.FirstName} {this.LastName} \nAge:{this.Age}");
            return sb.ToString();
        }
        //public void PrintStudent()
        //{
        //    Console.WriteLine($"Name:{this.FirstName} {this.LastName} \nGrade:{this.Grade} \nAge:{this.Age}");
        //}
    }
}