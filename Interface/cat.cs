using AnimalSound.Interfaces;

namespace AnimalSound
{
    public class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
}

