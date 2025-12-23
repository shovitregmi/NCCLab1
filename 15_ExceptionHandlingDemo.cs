using System;

namespace ShovitNCCLab
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }

    class ExceptionHandlingDemo
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int x = int.Parse(Console.ReadLine());
                if (x < 0) throw new CustomException("Negative numbers are not allowed.");
                Console.WriteLine("Number entered: " + x);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception: " + ex.Message);
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
            
Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
