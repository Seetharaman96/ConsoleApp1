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
            Console.WriteLine("Please enter your first name");

            string FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");

            string LastName = Console.ReadLine();

            //Console.WriteLine("Hello {0}{1}", FirstName, LastName);

            Console.WriteLine("Hello " + FirstName + LastName);

            Main1();
        }
    }
}