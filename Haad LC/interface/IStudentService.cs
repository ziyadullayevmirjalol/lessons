using Haad_LC.models;

namespace Haad_LC.@interface
{
    public interface IStudentService
    {
        void Create(Student student);
        bool Delete(int id);
        bool Update(int id, string firsname, string lastname, Subject subject, DateTime dateofbirth);
        void GetAll();
        List<Student> GetByName(string firstname);
        bool GetById(int id);
        List<Student> GetEnglishLearners();
        List<Student> GetAdults();
    }
}
