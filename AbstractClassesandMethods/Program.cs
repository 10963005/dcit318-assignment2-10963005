using System;
namespace Abstract
{
    // Abstract class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    //Derived class
    class Circle : Shape
    {
        public double Radius { get; set; }

        //Constructor to initialize the radius
        public Circle(double radius)
        {
            Radius = radius;
        }

        //To implement the GetArea method
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    //Derived class Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        //constructor to initialize width and height
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementing the GetArea method
        public override double GetArea()
        {
            return Width * Height;
        }

        //Main class
        class Program
        {
            static void Main(string[] args)
            {
                //Creating Circle and Rectangle instances
                Circle myCircle = new Circle(5);
                Rectangle myRectangle = new Rectangle(4, 6);
            }
        }
    }
}
