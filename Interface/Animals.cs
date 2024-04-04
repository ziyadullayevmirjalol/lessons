using AnimalSound.Interfaces;

namespace AnimalSound
{
    public class Animals : IAnimal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animals sound");
        }
    }
}
