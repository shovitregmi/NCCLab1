using System;
using System.Collections;
using System.Collections.Generic;

namespace ShovitNCCLab
{
    class CollectionsDemo
    {
        public static void Run()
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("Hello");
            arr.Add(3.14);
            Console.WriteLine("ArrayList Contents:");
            foreach (var item in arr) Console.WriteLine(item);

            List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");
            Console.WriteLine("\nGeneric List Contents:");
            foreach (var fruit in list) Console.WriteLine(fruit);

            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");

        }
    }
}
