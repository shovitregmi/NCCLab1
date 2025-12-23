using System;

namespace ShovitNCCLab
{
    struct Point
    {
        public int X, Y;
    }

    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    partial class PartialExample
    {
        public void Part1() => Console.WriteLine("Part 1 of Partial Class");
    }

    partial class PartialExample
    {
        public void Part2() => Console.WriteLine("Part 2 of Partial Class");
    }

    class StructEnumPartialDemo
    {
        public static void Run()
        {
            Point p = new Point { X = 10, Y = 20 };
            Console.WriteLine($"Point: X={p.X}, Y={p.Y}");

            Days today = Days.Wednesday;
            Console.WriteLine($"Today is: {today}");

            PartialExample pe = new PartialExample();
            pe.Part1();
            pe.Part2();

            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");

        }
    }
}
