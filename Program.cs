using System;

namespace MyApp
{
    internal class Program
    {
        static void Main2()
        {
            Console.WriteLine("Hello Galaxy");
        }
        static void Main1()
        {
            Console.WriteLine("Hello Universe");
            Main2();
        }
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Main1();
        }
    }
}