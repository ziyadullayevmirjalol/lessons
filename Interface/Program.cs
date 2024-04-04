using AnimalSound;
using AnimalSound.Interfaces;

IAnimal Animals = new Animals();
IAnimal Dog = new Dog();
IAnimal Goat = new Goat();
IAnimal Cat = new Cat();


Animals.Sound();
Dog.Sound();
Goat.Sound();
Cat.Sound();


