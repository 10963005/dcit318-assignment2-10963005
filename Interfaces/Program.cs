using System;
namespace Application
{
    //Interface
    interface IMovable
    {
        void Move();
    }

    //Implementation
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    //Main class
    class Program
    {
        static void Main(string[] args)
        {
           IMovable myCar = new Car();
           IMovable myBicycle = new Bicycle();

            myCar.Move();
            myBicycle.Move();
        }
    }
}
     
