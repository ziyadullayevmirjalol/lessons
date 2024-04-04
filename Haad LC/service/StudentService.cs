using Haad_LC.@interface;
using Haad_LC.models;


namespace Haad_LC.service
{
    public class StudentService : IStudentService
    {

        private List<Student> students = new();

        public void Create(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("student created");
            Console.WriteLine("-----------------------------");

        }
        public bool Delete(int id)
        {
            var studentFound = false;
            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    students.Remove(student);
                    Console.WriteLine($"Student with ID-{id} deleted ");
                    studentFound = true;
                    break;
                }
            }
            return studentFound;
        }
        public bool Update(int id, string firstname, string lastname, Subject subject, DateTime dateofbirth)
        {
            var studentFound = false;
            foreach (Student student in students)
            {
                if (student.Id == id)
                {
                    student.FirstName = firstname;
                    student.LastName = lastname;
                    Console.WriteLine($"Student updated ID-{id} deleted ");
                    studentFound = true;
                    break;
                }
            }
            return studentFound;
        }
        public List<Student> GetAdults()
        {
            List<Student> list = new();

            foreach (var item in students)
            {

            }
            return list;
        }
        public void GetAll()
        {
            foreach (Student student in students)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Student's ID: {student.Id}");
                Console.WriteLine($"Student's firstname: {student.FirstName}");
                Console.WriteLine($"Student's lastname: {student.FirstName}");
                Console.WriteLine($"Student's date of birth: {student.DateOfBirth}");
                Console.WriteLine($"-----------------------------");

            }
        }
        public bool GetById(int id)
        {

            var studentFound = false;
            foreach (Student student in students)
            {
                if (id == student.Id)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"Student's firstname: {student.FirstName}");
                    Console.WriteLine($"Student's lastname: {student.FirstName}");
                    Console.WriteLine($"Student's date of birth: {student.DateOfBirth}");
                    Console.WriteLine("-----------------------------");
                    studentFound = true;
                    break;
                }
            }
            return studentFound;
        }
        public List<Student> GetByName(string firstname)
        {
            List<Student> list = new List<Student>();

            foreach (Student student in students)
            {

                if (firstname == student.FirstName)
                {
                    list.Add(student);
                }
            }
            return list;
        }
        public List<Student> GetEnglishLearners()
        {
            List<Student> list = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Subject == Subject.English)
                {
                    list.Add(student);
                }
            }
            return list;
        }
    }
}
