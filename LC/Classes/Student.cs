using LC.Services;

namespace LC.Classes
{
    internal class Student : ILearningCentre
    {
        public int id { get; set; }
        private string Name { get; set; }
        private string DateOfBirth { get; set; }
        private Subject Subject { get; set; }

        public Student(string name, string dateofbirth)
        {
            Name = name;
            DateOfBirth = dateofbirth;
        }
        public Student()
        {
        }
    }
}
