using System;

public class StudentController
{
    public void GetFilteredStudents()
    {
        DateTime startDate = new(1999, 04, 25);
        DateTime endDate = new(2015, 09, 09);


        StudentService studentService = new StudentService();
        Student[] students = studentService.ShowAllStudent(startDate, endDate);

        foreach (var student in students)
        {
            var result = $"{student.name} - {student.surname}";
            Console.WriteLine(result);
        }

    }





    public void GetShowMeTheId()
    {

        int firstId = 1;
        int lastId = 4;

        StudentService studentservice = new();

        Student[] students = studentservice.GetById(firstId, lastId);

        foreach (var student in students)
        {
            Console.WriteLine(student.name + " " + student.surname);
        }

    }




    public void StudentAge()
    {
        StudentService service = new();

        Console.WriteLine(service.GettStudentAgeById(2));
    }

}


