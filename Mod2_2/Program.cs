using System;
using static System.Console;
using static System.Math;

namespace Mod2_2
{
    abstract class Shape
    {
        // Метод для расчёта Площади
        public abstract double Area();

        // Метод для расчёта Периметра
        public abstract double Perimetr();
    }
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return PI * radius * radius;
        }

        public override double Perimetr()
        {
            return 2* PI * radius;
        }
    }

    class Rectangle:Shape
    {
        private double Width;
        private double Height;

        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimetr()
        {
            return 2 * (Width + Height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape Circle = new Circle(5);
            WriteLine($"Площадь круга {Circle.Area()}");
            WriteLine($"Периметр круга {Circle.Perimetr()}");
            WriteLine();

            Shape Rectangle = new Rectangle(5, 3);
            WriteLine($"Площадь прямоугольника: {Rectangle.Area()}");
            WriteLine($"Периметр прямоугольника: {Rectangle.Perimetr()}");
        }
    }
}