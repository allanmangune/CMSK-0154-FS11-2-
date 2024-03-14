using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Assignment
{
    public class Student
    {
        public string Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public StudentType? Type { get; set; }

        public Student CreateStudent(string id, string firstName, string lastName, StudentType type)
        {
            if (id == null)
            {
                id = "0";
            }
            if (firstName == null)
            {
                firstName = StudentType.Unknown.ToString();
            }
            if (lastName == null)
            {
                lastName = "";
            }

            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Type = type;
            return this;
        }

        public void OutputStudent(Student student)
        {
            Console.WriteLine($"Student: {student.Id} {student.FirstName} {student.LastName} ({student.Type})");
        }

    }
}
