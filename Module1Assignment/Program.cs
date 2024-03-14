using Module1Assignment;

Console.WriteLine("Assignment One");
var student1 = CreateStudent(001, "John", "Smith", StudentType.FullTime);
OutputStudent(student1);
var student2 = CreateStudent(002, "Taylor", "Dane", StudentType.FullTime);
OutputStudent(student2);
var student3 = CreateStudent(003, "Sandy", "Williams", StudentType.FullTime);
OutputStudent(student3);

/* Test the if statements of the CreateStudent method
var student1 = CreateStudent(null, "John", "Smith", StudentType.FullTime);
OutputStudent(student1);
var student2 = CreateStudent(002, null, "Dane", StudentType.FullTime);
OutputStudent(student2);
var student3 = CreateStudent(003, "Sandy", "Williams", StudentType.FullTime);
OutputStudent(student3);
*/

Student CreateStudent(int? id, string firstName, string lastName, StudentType type)
{
    if (id == null)
    {
        id = 0;
    }
    var student = new Student();
    student.Id = (int)id;
    student.Type = type;
    student.FirstName = firstName ?? StudentType.Unknown.ToString();
    student.LastName = lastName ?? string.Empty;
    return student;
}

void OutputStudent(Student student)
{
    Console.WriteLine($"Student: {student.Id} {student.FirstName} {student.LastName} ({student.Type})");
}