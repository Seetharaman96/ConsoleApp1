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
//---------------------------------------------------------------------------------------------------------------
            //Escape sequences
            string Name = "\"SR\"";

            Console.WriteLine(Name);

            //new line
            string Num = "One\nTwo\nThree";

            Console.WriteLine(Num);

            //to escape sequences with double backslash
            string path = "C:\\Seetha\\C#\\Projects";

            Console.WriteLine(path);
//---------------------------------------------------------------------------------------------------------------
            //verbatim literal(@)
            string verb = @"C:\Seetha\C#\Projects";

            Console.WriteLine(verb);
//---------------------------------------------------------------------------------------------------------------
            //Common operators
            int i = 10;

            int Numerator = 10;
            int denominator = 2;
            int result = Numerator / denominator;
            int result1 = Numerator % denominator;
            Console.WriteLine(result);
            Console.WriteLine(result1);
//---------------------------------------------------------------------------------------------------------------
            //ternary operator
            int Numbers = 10;
            bool isNumber10 = Numbers == 10 ? true : false;
            //Console.WriteLine(isNumber10);
//---------------------------------------------------------------------------------------------------------------
            //Value types
            //int seet = null; //is not possible value types cannot be null but we can make value types to nullable using below example

            int? seet = null;

            //bool AreYouMajor = true;
            bool ? AreYouMajor = null;
            //AreYouMajor.Value is defined as true
            if (AreYouMajor == true)
            {
                Console.WriteLine("User is major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("User is minor");
            }
            else
            {
                Console.WriteLine("User did not answer the question");
            }
//---------------------------------------------------------------------------------------------------------------
            //null coalescing operator
            int? TicketsOnSale = null;
            //int? TicketsOnSale = 100;
            //int AvailableTickets
            int AvailableTickets = TicketsOnSale ?? 0; //instead of so much line using if else below, we can just use null coalesing operator, if the TicketsOnSale is null it will print 0 otherwise it will print the TicketsOnSale value.
            //if(TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = (int)TicketsOnSale; //converting nullable value to non-nullable value
            //}
            Console.WriteLine("Available tickets " + AvailableTickets);

            //datatype conversion
            //implicit conversion
            int num = 100;

            float num1 = num; //converting int datatype to float there is no dataloss in this so the implicit conversion is done by the compiler

            Console.WriteLine(num1);

            //explicit conversion
            float num2 = 123.45F;
            //two ways to make a explicit conversion
            //typecast operator
            int num3 = (int)num2; //here there will be a data loss, so if we have to make the datatype conversion from float to int, we have to make it explicitly
            //convert class
            int num4 = Convert.ToInt32(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            //Parse() and TryParse()
            //string strNumber = "100";
            string strNumber = "100TG";
            //int n = int.Parse(strNumber);
            int n = 0;
            bool isConversionSuccessful = int.TryParse(strNumber, out n);
            Console.WriteLine(isConversionSuccessful);
            if (isConversionSuccessful)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }

            //Array
            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;
            Console.WriteLine(EvenNumbers);
            Console.WriteLine(EvenNumbers[1]);

            //// Multiple switch cases
            //Console.WriteLine("Please Enter a number");
            //int number = int.Parse(Console.ReadLine());

            //switch(number)
            //{
            //    case 10:
            //    case 20:
            //    case 30:
            //        Console.WriteLine("Your number is {0}", number);
            //        break;
            //    default:
            //        Console.WriteLine("Your number is nor 10, 20 and 30");
            //        break;
            //}

            ////switch case with goto
            //int TotalCoffeeCost = 0;
            //Start:
            //Console.WriteLine("Please select your coffee size : 1-Small, 2-Medium, 3-Large");
            //int UserChoice = int.Parse(Console.ReadLine());

            //switch(UserChoice)
            //{
            //    case 1:
            //        TotalCoffeeCost += 1;
            //        break;
            //    case 2:
            //        TotalCoffeeCost += 2;
            //        break;
            //    case 3:
            //        TotalCoffeeCost += 3;
            //        break;
            //    default:
            //        Console.WriteLine("Your choice {0} is invalid", UserChoice);
            //        goto Start;
            //}

            //Console.WriteLine("Do you want another coffee - Yes or No");
            //string UserDecision = Console.ReadLine();

            //Decide:
            //switch(UserDecision.ToUpper())
            //{
            //    case "YES":
            //        goto Start;
            //    case "NO":
            //        break;
            //    default:
            //        Console.WriteLine("Your choice is {0} is invalid. please try again...", UserDecision);
            //        goto Decide;
            //}

            //Console.WriteLine("Thanks for shopping with us");
            //Console.WriteLine("Your bill amount is {0}", TotalCoffeeCost);

            //while loop
            //Console.WriteLine("Please enter your target");
            //int UserTarget = int.Parse(Console.ReadLine());
            //int InitialValue = 0;
            //while(InitialValue <= UserTarget)
            //{
            //    Console.Write(InitialValue + " ");
            //    InitialValue += 2;
            //}

            //doWhile loop
            //string UsrDec = string.Empty;
            //do
            //{
            //    Console.WriteLine("Please enter your target");
            //    int UsrCh = int.Parse(Console.ReadLine());
            //    int Start = 0;
            //    while (Start <= UsrCh)
            //    {
            //        Console.Write(Start + " ");
            //        Start += 2;
            //    }
            //    do
            //    {
            //        Console.WriteLine("Do you want to continue Yes or No");
            //        UsrDec = Console.ReadLine().ToUpper();
            //        if (UsrDec != "YES" && UsrDec != "NO")
            //        {
            //            Console.WriteLine("Invalid choice please say yes or no");
            //        }
            //    } while (UsrDec != "YES" && UsrDec != "NO");
            //} while (UsrDec == "YES");
            
            //Main1();
        }
    }
}