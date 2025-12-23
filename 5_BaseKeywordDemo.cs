using System;

namespace ShovitNCCLab
{
    class BaseClass
    {
        public int number = 42;
        public BaseClass() { Console.WriteLine("Base Constructor"); }
        public void Show() => Console.WriteLine("Base Method"); 

    }

    class DerivedClass : BaseClass
    {
        public DerivedClass() : base() { Console.WriteLine("Derived Constructor"); }
        public void Display()
        {
            Console.WriteLine("Accessing base field: " + base.number);
            base.Show();
        }
    }

    class BaseKeywordDemo
    {
        public static void Run()
        {
            DerivedClass d = new DerivedClass();
            d.Display();
            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }

}
