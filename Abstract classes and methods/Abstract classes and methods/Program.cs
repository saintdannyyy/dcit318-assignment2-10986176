using System;

namespace AbstractClassesAndMethods
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private double radius;

        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        
        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");       
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}"); 
        }
    }
}
