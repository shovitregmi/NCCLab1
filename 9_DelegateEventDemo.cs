using System;

namespace ShovitNCCLab
{
    delegate void MyDelegate(string msg);

    class EventPublisher
    {
        public event MyDelegate OnNotify;

        public void Trigger(string message)
        {
            OnNotify?.Invoke(message);
        }
    }

    class DelegateEventDemo
    {
        static void PrintMessage(string msg) => Console.WriteLine("Message: " + msg);

        public static void Run()
        {
            MyDelegate del = PrintMessage;
            del("Hello from delegate!");

            del += (msg) => Console.WriteLine("Additional handler: " + msg);
            del("Multicast Delegate Called");

            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Func Delegate Sum: {add(5, 10)}");

            Action<string> show = (text) => Console.WriteLine("Action Delegate: " + text);
            show("Hello");

            MyDelegate anon = delegate (string s) { Console.WriteLine("Anonymous Method: " + s); };
            anon("Hi there!");

            EventPublisher publisher = new EventPublisher();
            publisher.OnNotify += PrintMessage;
            publisher.Trigger("Event triggered!");

            Console.WriteLine("\nName: Shovit Regmi\nRoll no: 32");

        }
    }
}
