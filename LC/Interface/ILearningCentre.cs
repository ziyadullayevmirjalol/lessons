using LC.Classes;
using Microsoft.VisualBasic;

namespace LC.Services
{
    public interface ILearningCentre
    {
        void GetAllStudents();
        void AddStudent(string firstname, string lastname, DateAndTime dateofbirth);
        void DeleteStudent(int id);
        void UpdateStudent(int id, string firstname, string lastname, DateAndTime dateofbirth);
        void GetStudentByID(int id);
        void GetStudentByName(string name);
        void ShowStudentsWhoStudiesEnglish(Subject subjects);
        void ShowStudentsWhoseOlderThan18(DateAndTime age);
    }
}
