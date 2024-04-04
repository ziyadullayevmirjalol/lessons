using AnimalSound.Interfaces;

namespace AnimalSound
{
    public class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Bark");
        }
    }
}

