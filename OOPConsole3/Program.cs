using System;

namespace OOP3Console
{
    class Program
    {
        static void Main()
        {
            Shape square = new Square("Yellow", 10);
            square.displayInfo();
            Console.WriteLine("The Area of Square is: " + square.getArea());
            square.Dispose();
            Shape create = new Circle("Green", 5);
            create.displayInfo();
            Console.WriteLine("The Area of Circle is: " + create.getArea());
            create.Dispose();
        }
    }
    public abstract class Shape
    {
        public string color;
        public double sideLength;

        public Shape(string color, double sideLength)
        {
            this.color = color;
            this.sideLength = sideLength;
        }

        public abstract double getArea();
        public abstract void displayInfo();
        public virtual void setData(string color, double sideLength)
        {
            this.color = color;
            this.sideLength = sideLength;
        }   
        ~Shape()
        {
            Console.WriteLine("Shape Destroyed");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Shape Destroyed");
        }
    }

        public class Square : Shape
        {
            public Square(string color, double sideLength) : base(color, sideLength)
        {
    }

    public override double getArea()
    {
        return sideLength * sideLength;
    }
    public override void displayInfo()
    {
        Console.WriteLine("The color is: " + color);
    }
}
    public class Circle : Shape
    {
        public Circle(string color, double radius) : base(color, radius)
{}
        public override double getArea()
        {
            return Math.PI * sideLength * sideLength;
        }
        public override void displayInfo()
        {
            Console.WriteLine("The color is: " + color);
        }
    }
}