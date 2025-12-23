using System;

namespace ShovitNCCLab
{
    class JaggedArrayDemo
    {
        public static void Run()
        {
            int[][] jagged = new int[2][];
            jagged[0] = new int[] {1,2,3};
            jagged[1] = new int[] {4,5};
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                foreach (int val in jagged[i])
                    Console.Write(val + " ");
                Console.WriteLine();
            }
            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");


        }
    }
}
