using LC.Classes;
using Microsoft.VisualBasic;

namespace LC.Services
{
    public class StudentService : ILearningCentre
    {
        public void AddStudent(string firstname, string lastname, DateAndTime dateofbirth)
        {

        }

        public void DeleteStudent(int id)
        {

        }

        public void GetAllStudents()
        {
            foreach (Student student in Students)
            {

            }
        }

        public void GetStudentByID(int id)
        {

        }

        public void GetStudentByName(string name)
        {

        }

        public void ShowStudentsWhoseOlderThan18(DateAndTime age)
        {

        }

        public void ShowStudentsWhoStudiesEnglish(Subject subjects)
        {

        }

        public void UpdateStudent(int id, string firstname, string lastname, DateAndTime dateofbirth)
        {

        }
    }
}