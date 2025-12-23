using System;
using System.Linq;

namespace ShovitNCCLab
{
    class LambdaLinqDemo
    {
        public static void Run()
        {
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine("Multiplication using Lambda: " + multiply(5, 4));

            int[] numbers = { 10, 15, 20, 25, 30 };
            var multiplesOfTen = numbers.Where(n => n % 10 == 0);
            Console.WriteLine("Multiples of 10:");
            foreach (var num in multiplesOfTen) Console.WriteLine(num);
            
Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
