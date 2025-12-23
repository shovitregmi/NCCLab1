using System;

namespace ShovitNCCLab
{
    [Obsolete("This class is obsolete, use NewClass instead")]
    class OldClass
    {
        public void Show() => Console.WriteLine("OldClass Show()");
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MyCustomAttribute : Attribute
    {
        public string Description { get; }
        public MyCustomAttribute(string desc) => Description = desc;
    }

    [MyCustomAttribute("This is a custom attribute example")]
    class NewClass
    {
        public void Display() => Console.WriteLine("NewClass Display()");
    }

    class AttributeDemo
    {
        public static void Run()
        {
            OldClass oldObj = new OldClass();
            oldObj.Show();

            NewClass newObj = new NewClass();
            newObj.Display();
            
Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
