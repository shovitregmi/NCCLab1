using System;

namespace ShovitNCCLab
{
    class ConstructorDemo
    {
        int a; string name;

        public ConstructorDemo() { Console.WriteLine("Default Constructor"); }
        public ConstructorDemo(int x) { a = x; Console.WriteLine("Parameterized Constructor with int: " + a); }
        public ConstructorDemo(string n) { name = n; Console.WriteLine("Parameterized Constructor with string: " + name); }
        public ConstructorDemo(ConstructorDemo obj) { a = obj.a; name = obj.name; Console.WriteLine("Copy Constructor: " + a + ", " + name); }
        static ConstructorDemo() { Console.WriteLine("Static Constructor"); }


        public static void Run()
        {
            ConstructorDemo obj1 = new ConstructorDemo();
            ConstructorDemo obj2 = new ConstructorDemo(42);
            ConstructorDemo obj3 = new ConstructorDemo("Hello");
            ConstructorDemo obj4 = new ConstructorDemo(obj2);

            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
