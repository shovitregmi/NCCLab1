using System;

namespace ShovitNCCLab
{
    abstract class Shape
    {
        public abstract double Area();
    }

    interface IColor
    {
        void SetColor(string color);
    }

    interface IShapeInfo
    {
        void DisplayInfo();
    }

    class Rectangle : Shape, IColor, IShapeInfo
    {
        double width, height;
        string color;

        public Rectangle(double w, double h) { width = w; height = h; }
        public override double Area() => width * height;
        public void SetColor(string c) => color = c;
        public void DisplayInfo() => Console.WriteLine($"Rectangle Color: {color}, Area: {Area()}");
    }

    class AbstractInterfaceDemo
    {
        public static void Run()
        {
            Rectangle rect = new Rectangle(5, 10);
            rect.SetColor("Red");
            rect.DisplayInfo();

            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");

        }
    }
}
