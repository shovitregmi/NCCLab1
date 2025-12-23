using System;
using System.Threading.Tasks;

namespace ShovitNCCLab
{
    class AsyncAwaitDemo
    {
        public static async Task Run()
        {
            Console.WriteLine("Starting async task...");
            await Task.Delay(2000);
            Console.WriteLine("Task completed after delay");
            
Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
