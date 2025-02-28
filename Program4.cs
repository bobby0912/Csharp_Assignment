//using c__Assignment;

//**Abstraction with Abstract Classes**

//Design an abstract class `Shape` with an abstract method `CalculateArea()`. Create derived classes `Circle` and `Rectangle` that implement this method. Demonstrate abstraction by instantiating these classes.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Shape circle = new Circle(5);
    //        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

    //        Shape rectangle = new Rectangle(4, 6);
    //        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
    //    }
    //}
}
