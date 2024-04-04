using AnimalSound.Interfaces;

namespace AnimalSound
{
    public class Goat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Mheeeeeh");
        }
    }
}

