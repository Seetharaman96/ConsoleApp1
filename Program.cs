using System;
using System.Security.AccessControl;

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
            //Console.WriteLine("Please enter your first name");

            //string FirstName = Console.ReadLine();

            //Console.WriteLine("Please enter your last name");

            //string LastName = Console.ReadLine();

            ////Console.WriteLine("Hello {0}{1}", FirstName, LastName);

            //Console.WriteLine("Hello " + FirstName + LastName);

            bool b = true;

            Console.WriteLine(b);

            Console.WriteLine("Min Value = " + int.MinValue);

            Console.WriteLine("Max Value = " + int.MaxValue);

            //Escape sequences
            string Name = "\"SR\"";

            Console.WriteLine(Name);

            //new line
            string Num = "One\nTwo\nThree";

            Console.WriteLine(Num);

            //to escape sequences with double backslash
            string path = "C:\\Seetha\\C#\\Projects";

            Console.WriteLine(path);

            //verbatim literal(@)
            string verb = @"C:\Seetha\C#\Projects";

            Console.WriteLine(verb);

            //Common operators
            int i = 10;

            int Numerator = 10;
            int denominator = 2;
            int result = Numerator / denominator;
            int result1 = Numerator % denominator;
            Console.WriteLine(result);
            Console.WriteLine(result1);

            //ternary operator
            int Numbers = 10;
            bool isNumber10 = Numbers == 10 ? true : false;
            Console.WriteLine(isNumber10);

            Main1();
        }
    }
}