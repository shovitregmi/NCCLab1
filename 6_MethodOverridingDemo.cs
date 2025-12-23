using System;

namespace ShovitNCCLab
{
    class Parent
    {
        public virtual void Show() => Console.WriteLine("Parent Show()");
        public void Hide() => Console.WriteLine("Parent Hide()");
    }

    class Child : Parent
    {
        public override void Show() => Console.WriteLine("Child Show() - Overridden");
        public new void Hide() => Console.WriteLine("Child Hide() - Hidden");
    }

    class MethodOverridingDemo
    {
        public static void Run()
        {
            Parent p = new Parent();
            p.Show();
            p.Hide();

            Parent pc = new Child();
            pc.Show();
            pc.Hide();

            Child c = new Child();
            c.Show();
            c.Hide();

            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");

        }
    }
}
