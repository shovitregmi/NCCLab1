using System;
using System.IO;

namespace ShovitNCCLab
{
    class FileWriteDemo
    {
        public static void Run()
        {
            Console.WriteLine("Enter text to write to file (type 'exit' to stop):");
            string path = "output.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                string input;
                while ((input = Console.ReadLine()) != "exit")
                {
                    sw.WriteLine(input);
                }
            }
            Console.WriteLine("Data written to " + path);
            
Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
