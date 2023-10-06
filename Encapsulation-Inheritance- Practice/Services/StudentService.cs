using System;



public class StudentService
{


    private Student[] GetAll()

    {
        Student student1 = new()
        {
            name = "Semed",
            surname = "Huseynov",
            email = "semed@mail.com",
            birthday = new(2015, 04, 20),
            id = 1
        };

        Student student2 = new()
        {
            name = "Elnur",
            surname = "Memmedov",
            email = "semed@mail.com",
            birthday = new(2003, 04, 24),
            id = 2
        };

        Student student3 = new()
        {
            name = "Tunzale",
            surname = "Memmmedova",
            email = "tunzale@mail.com",
            birthday = new(1999, 08, 08),
            id = 3
        };


        return new Student[] { student1, student2, student3 };

    }


    public Student[] ShowAllStudent(DateTime StartDate, DateTime EndDate)
    {
        Student[] students = GetAll();
        var result = students.Where(x => x.birthday > StartDate && x.birthday < EndDate).ToArray();
        return result;

    }



    private Student[] GetAllStudents()

    {
        Student student1 = new()
        {
            name = "Semed",
            surname = "Huseynov",
            email = "semed@mail.com",
            birthday = new(2015, 04, 20),
            id = 1
        };

        Student student2 = new()
        {
            name = "Elnur",
            surname = "Memmedov",
            email = "semed@mail.com",
            birthday = new(2003, 04, 24),
            id = 2
        };

        Student student3 = new()
        {
            name = "Tunzale",
            surname = "Memmmedova",
            email = "tunzale@mail.com",
            birthday = new(1999, 08, 08),
            id = 3
        };

        return new Student[] { student1, student2, student3 };

    }

    public Student[] GetById(int firstId, int lastId)
    {
        Student[] students = GetAllStudents();

        var result = students.Where(x => x.id > firstId && x.id < lastId).ToArray();

        return result;


    }


    public int GettStudentAgeById(int id)
    {
        Student [] students = GetAllStudents();

        Student student = students.FirstOrDefault(m => m.id == id);

        int result = DateTime.Now.Year - student.birthday.Year;

        return result;
    }






}






