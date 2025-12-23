using System;
using System.Linq;

namespace ShovitNCCLab
{
    class LinqDemo
    {
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenNumbers = from n in numbers where n % 2 == 0 select n;
            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers) Console.WriteLine(num);
            
Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
