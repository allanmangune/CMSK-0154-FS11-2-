using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Assignment
{
    public class Student
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public StudentType? Type { get; set; }

        public Student CreateStudent(int? id, string firstName, string lastName, StudentType type)
        {
            if (id == null)
            {
                id = 0;
            }

            Student student = new Student(); //Required by the assignment. Alternatively, assign the values to the class properties and then return the this instance.
            student.Id = (int)id;
            student.Type = type;
            student.FirstName = firstName ?? StudentType.Unknown.ToString();
            student.LastName = lastName ?? string.Empty;
            return student;
        }

        public void OutputStudent(Student student)
        {
            Console.WriteLine($"Student: {student.Id} {student.FirstName} {student.LastName} ({student.Type})");
        }

    }
}
