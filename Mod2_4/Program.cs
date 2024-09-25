using System;
using static System.Console;

namespace Mod2_4
{
    interface IDrawable
    {
        void Draw();
    }

    class Circle : IDrawable
    {
        public void Draw()
        {
            WriteLine("Drawing a Circle.");
        }
    }

    class Rectangle : IDrawable
    {
        public void Draw()
        {
            WriteLine("Drawing a Rectangle.");
        }
    }

    class Triangle : IDrawable
    {
        public void Draw()
        {
            WriteLine("Drawing a Triangle.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDrawable[] shapes = new IDrawable[]
            {
            new Circle(),
            new Rectangle(),
            new Triangle()
            };

            foreach (IDrawable shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
