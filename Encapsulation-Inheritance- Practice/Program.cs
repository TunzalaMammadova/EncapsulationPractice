



static void GetFilteredStudents()
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

//GetFilteredStudents();



static void GetShowMeTheId()
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

//GetShowMeTheId();



static void StudentAge()
{
    StudentService service = new();

    Console.WriteLine(service.GettStudentAgeById(2));
}

//StudentAge();



Car car = new();

car.color = "red";

car.Vin = "Salam";

car.speed = 500;

//Console.WriteLine(car.Vin);


//StudentController studentController = new();
//studentController.StudentAge();



BookController bookController = new();
bookController.GetAllByAuthor();
bookController.GetById();
bookController.Search();