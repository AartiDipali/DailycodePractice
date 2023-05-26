using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPracticeCodeCSHARP
{
    public class Decisionmaking
    {
      public void ConditionalProblems()
        {
            //Console.WriteLine("Hello, World!");
            //int a;
            //int b;
            //int c;
            ////number input acceptance
            //Console.WriteLine("Enter First Number");
            //a=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //b =Convert.ToInt32(Console.ReadLine());
            //c = a + b;
            //Console.WriteLine("The Result is {0}",c);


            ////string input accpetance

            //string stringInput;
            //Console.WriteLine("Enter any string");
            //stringInput = Console.ReadLine();
            //Console.WriteLine("The result is {0}", stringInput);
            ////Conditional Code Practice

            ////if else
            ////else if ladder
            ////nested if else
            ////switch
            ////ternary operator

            ////If … ElseIf… Statement

            //int num1;
            //Console.WriteLine("Enter a number to identify");
            //num1= Convert.ToInt32(Console.ReadLine());

            //if(num1<0)
            //{
            //    Console.WriteLine("Number is negative");
            //}
            //else if(num1==0)
            //{
            //    Console.WriteLine("Number is equal");
            //}
            //else if(num1>0)
            //{
            //    Console.WriteLine("Number is positive");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}


            ////nested if Else

            //int input = 30;
            //if (input > 10)
            //{
            //    if (input == 20)
            //    {
            //        Console.WriteLine("The value of the integer is 20");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The value of the integer is not 20");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The value of integer is not greater than 10");
            //}


            ////Switch Case
            ////int dayChoice;
            ////dayChoice=Convert.ToInt32(Console.ReadLine());

            ////switch (dayChoice)
            ////{
            ////    case 0:Console.WriteLine("It's sunday");
            ////                break;
            ////    case 1:
            ////        Console.WriteLine("It's sunday");
            ////        break;
            ////    case 2:
            ////        Console.WriteLine("It's monday");
            ////        break;

            ////    default:Console.WriteLine("Not matching case");
            ////        break;



            ////}

            ////ternary operator

            //int number1;
            //int number2;
            //Console.WriteLine("enter a first number");
            //number1= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a second number");
            //number2 = Convert.ToInt32(Console.ReadLine());
            //string result;
            // result =(number1 > number2) ? "greater" : "smaller";
            //Console.WriteLine(result);
            //Console.ReadLine();


            //****************************Programs**************************************

            //***25/04/2022****Else if ladder
            Console.WriteLine("Calculator");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Substract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");

            Console.Write("Enter Choice(1-4):");
            int ch = Int32.Parse(Console.ReadLine());

            int a, b, c;

            if (ch == 1)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine("Sum = {0}", c);
            }
            else if (ch == 2)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a - b;
                Console.WriteLine("Difference = {0}", c);
            }
            else if (ch == 3)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a * b;
                Console.WriteLine("Product = {0}", c);
            }
            else if (ch == 4)
            {
                Console.Write("Enter A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter B:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Quotient = {0}", c);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }


            //Switch Case................................................................................
            string text = "";

            Console.Write("Enter some text: ");
            text = Console.ReadLine();

            switch (text.Substring(0, 4))
            {
                case "This":
                    Console.WriteLine("text started with \"This\"");
                    break;
                case "That":
                    Console.WriteLine("text started with \"That\"");
                    break;
                default:
                    Console.WriteLine("Invalid text...");
                    break;
            }

            //Ternary Operatopr


            int number1;
            int number2;
            Console.WriteLine("enter a first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            string result;
            result = (number1 > number2) ? "greater" : "smaller";
            Console.WriteLine(result);
            Console.ReadLine();

        }

    }

    



    
}
