using System;

namespace ShovitNCCLab
{
    class GenericClass<T>
    {
        private T data;
        public GenericClass(T value) { data = value; }
        public void ShowData() => Console.WriteLine("Data: " + data);
        public T GenericMethod(T input) => input;
    }

    class GenericClassDemo
    {
        public static void Run()
        {
            GenericClass<int> intObj = new GenericClass<int>(100);
            intObj.ShowData();
            Console.WriteLine("Generic Method Output: " + intObj.GenericMethod(200));
            
            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
