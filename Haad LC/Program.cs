using Haad_LC.@interface;
using Haad_LC.models;
using Haad_LC.service;

IStudentService service = new StudentService();

var loop = true;
while (loop)
{
    Console.WriteLine("Learning Centre (Student service)\n");
    Console.WriteLine("1. Add student");
    Console.WriteLine("2. update student");
    Console.WriteLine("3. delete student");
    Console.WriteLine("4. get all students");
    Console.WriteLine("5. get students by ID");
    Console.WriteLine("6. get students by name");
    Console.WriteLine("7. get english learners");
    Console.WriteLine("8. get adult students\n");
    Console.WriteLine("9. exit");
    var choice = Console.ReadLine();

    Console.Clear();


    switch (choice)
    {
        case "1":
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("-------Create Student-------\n");
            Console.WriteLine("--------------------------------");

            Console.Write("enter firstname: ");
            var cfirstname = Console.ReadLine();
            Console.Write("enter lastname: ");
            var clastname = Console.ReadLine();
        CSubject:
            Console.WriteLine("Subjects: (1. Math, 2. DataScience, 3. English, 4. Russian)");
            Console.Write("enter choice: ");

            var csubjectchoice = Console.ReadLine();
            Subject csubject = new Subject();

            switch (csubjectchoice)
            {
                case "1":
                    csubject = Subject.Math;
                    break;
                case "2":
                    csubject = Subject.DataScience;
                    break;
                case "3":
                    csubject = Subject.English;
                    break;
                case "4":
                    csubject = Subject.Russian;
                    break;
                default:
                    Console.Write("wrong choice, press any key to enter again.");
                    Console.ReadKey();
                    goto CSubject;
            }
            Console.Write("enter date of birth [d/mm/yyyy]: ");

            Student newStudent = new Student();
            newStudent.FirstName = cfirstname;
            newStudent.LastName = clastname;
            newStudent.Subject = csubject;
            //newStudent.DateOfBirth = cDateOfBirth;

            service.Create(newStudent);
            Console.WriteLine("--------------------------------");
            break;
        case "2":
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------Update student------");
            Console.WriteLine("--------------------------------");


            Console.Write("enter id: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("enter firstname: ");
            var ufistname = Console.ReadLine();
            Console.Write("enter lastname: ");
            var ulastname = Console.ReadLine();
        USubject:
            Console.WriteLine("Subjects: (1. Math, 2. DataScience, 3. English, 4. Russian)");
            Console.Write("enter choice: ");

            var usubjectchoice = Console.ReadLine();
            Subject usubject = new Subject();

            switch (usubjectchoice)
            {
                case "1":
                    usubject = Subject.Math;
                    break;
                case "2":
                    usubject = Subject.DataScience;
                    break;
                case "3":
                    usubject = Subject.English;
                    break;
                case "4":
                    usubject = Subject.Russian;
                    break;
                default:
                    Console.Write("wrong choice, press any key to enter again.");
                    Console.ReadKey();
                    goto USubject;
            }
            Console.Write("enter date of birth [d/mm/yyyy]: ");
            var uDateOfBirth = DateTime.Parse(Console.ReadLine());

            var uStudentRes = service.Update(id, ufistname, ulastname, usubject, uDateOfBirth);

            if (uStudentRes == false)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("student not found");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("--------------------------------");

            break;
        case "3":
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------Delete student------");
            Console.WriteLine("--------------------------------");


            Console.Write("enter id: ");
            var dId = int.Parse(Console.ReadLine());

            var dIDres = service.Delete(dId);

            if (dIDres == false)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("student not found");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("--------------------------------");

            break;
        case "4":
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------Get all students------");
            Console.WriteLine("--------------------------------");

            service.GetAll();
            Console.WriteLine("--------------------------------");

            break;
        case "5":
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------Get students by ID------");
            Console.WriteLine("--------------------------------");

            Console.Write("enter id: ");
            var gId = int.Parse(Console.ReadLine());

            var gIDRes = service.GetById(gId);

            if (gIDRes == false)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("student not found");
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine("--------------------------------");
            break;
        case "6":
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------Get students by Name------");
            Console.WriteLine("--------------------------------");

            Console.Write("enter name: ");
            var gName = Console.ReadLine();

            List<Student> studentsGotByName = new();
            studentsGotByName = service.GetByName(gName);


            foreach (Student student in studentsGotByName)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Student's firstname: {student.FirstName}");
                Console.WriteLine($"Student's lastname: {student.LastName}");
                Console.WriteLine($"Student's date of birth: {student.DateOfBirth}");
                Console.WriteLine("------------------");
            }

            Console.WriteLine("--------------------------------");

            break;
        case "7":
            Console.Clear();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("------Get English learners------");
            Console.WriteLine("--------------------------------");

            List<Student> EnglishLearners = new();
            EnglishLearners = service.GetEnglishLearners();

            foreach (Student student in EnglishLearners)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Student's firstname: {student.FirstName}");
                Console.WriteLine($"Student's lastname: {student.LastName}");
                Console.WriteLine($"Student's date of birth: {student.DateOfBirth}");
                Console.WriteLine("------------------");
            }

            Console.WriteLine("--------------------------------");

            break;
        case "8":
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("------Get Adult Students------");
            Console.WriteLine("-----------------------------------------------");

            var studentsGotByAge = service.GetAdults();

            foreach (Student student in studentsGotByAge)
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"Student's firstname: {student.FirstName}");
                Console.WriteLine($"Student's lastname: {student.LastName}");
                Console.WriteLine($"Student's date of birth: {student.DateOfBirth}");
                Console.WriteLine("------------------");
            }

            break;
        case "9":
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("exit service...");
            Console.WriteLine("-----------------------------------------------");

            loop = false;
            break;
    }
}