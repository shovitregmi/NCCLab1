using System;

namespace ShovitNCCLab
{
    class PropertyDemo
    {
        public int AutoProperty { get; set; }
        public string ReadOnlyProperty { get; } = "ReadOnly Value";

        public static void Run()
        {
            PropertyDemo p = new PropertyDemo();
            p.AutoProperty = 100;
            Console.WriteLine("AutoProperty: " + p.AutoProperty);
            Console.WriteLine("ReadOnlyProperty: " + p.ReadOnlyProperty);

            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");
        }
    }
}
