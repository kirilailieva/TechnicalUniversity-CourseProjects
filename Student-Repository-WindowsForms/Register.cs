using System.Collections.Generic;
using System.Linq;

namespace Kikk
{
    public class Register
    {
        public List<Student> students = new List<Student>();
        public Register()
        {
            students.Add(new Student("Georgi", "Georgiev", 4.67, 15));
            students.Add(new Student("Gergana", "Milenova", 5.67, 16));
            students.Add(new Student("Dimcho", "Dimchev", 4.10, 17));
            students.Add(new Student("Ivan", "Dimitrov", 2.67, 15));
            students.Add(new Student("Georgi", "Shishkov", 2.45, 17));
            students.Add(new Student("Dimitar", "Zlatev", 5.87, 19));
            students.Add(new Student("Denica", "Dinkova", 4.66, 16));
            students.Add(new Student("Kuncho", "Kunchev", 3.67, 15));
            students.Add(new Student("Kichka", "Kapkova", 5.98, 19));
        }
        public List<Student> GetExellentStudent()
        {
            List<Student> exellentStudents = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Grade >= 5.50)
                {
                    exellentStudents.Add(student);
                }
            }
            return exellentStudents;
        }
        public List<Student> GetFailedStudents()
        {
            return this.students.Where(x => x.Grade < 3.00).ToList();
        }

        internal List<Student> GetOlderStudents()
        {
            return this.students.Where(x => x.Age >= 18).ToList();
        }

        internal bool IsFailing()
        {
            return this.students.Any(x => x.Grade < 3.00);
        }
    }
}