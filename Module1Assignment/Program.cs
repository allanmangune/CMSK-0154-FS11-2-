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
var student2 = CreateStudent("002", null, "Dane", StudentType.FullTime);
OutputStudent(student2);
var student3 = CreateStudent("003", "Sandy", "Williams", StudentType.FullTime);
OutputStudent(student3);
*/

Student CreateStudent(int? id, string firstName, string lastName, StudentType type)
{
    if (id == null)
    {
        id = 0;
    }
    if (firstName == null)
    {
        firstName = StudentType.Unknown.ToString();
    }
    if (lastName == null)
    {
        lastName = "";
    }

    var student = new Student();
    student.Id = (int)id;
    student.FirstName = firstName;
    student.LastName = lastName;
    student.Type = type;
    return student;
}

void OutputStudent(Student student)
{
    Console.WriteLine($"Student: {student.Id} {student.FirstName} {student.LastName} ({student.Type})");
}