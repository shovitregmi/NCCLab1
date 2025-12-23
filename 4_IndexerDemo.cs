using System;

namespace ShovitNCCLab
{
    class IndexerDemo
    {
        private string[] data = new string[3];

        public string this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }

        public string this[string index]
        {
            get => index == "first" ? data[0] : data[1];
            set
            {
                if (index == "first") data[0] = value; else data[1] = value;
            }
        }

        public static void Run()
        {
            IndexerDemo idx = new IndexerDemo();
            idx[0] = "Zero";
            idx["first"] = "First Element";
            Console.WriteLine("Int index: " + idx[0]);
            Console.WriteLine("String index: " + idx["first"]);
            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
