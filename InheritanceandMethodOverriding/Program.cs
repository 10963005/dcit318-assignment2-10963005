using System;
namespace Application
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    { 
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        } 
    }

    //Main Class
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            //Calling the MakeSound method on each instance
            myAnimal.MakeSound();
            myDog.MakeSound();
            myCat.MakeSound();  
        }
    }
}