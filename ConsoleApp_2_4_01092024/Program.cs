using System;
using System.Runtime.InteropServices;
using Number = System.Int32;

namespace ConsoleApp_2_4_01092024
{
    internal class Program
    {
        //Function/Method
        static void Main(string[] args)
        {

            //Console.WriteLine("Welcome to QuickXpert!");
            //Console.ReadKey();

            //Console.Write("Enter Age : ");
            //byte Age = Convert.ToByte(Console.ReadLine());

            //Console.Write("Enter Name : ");
            //string Name = Console.ReadLine();

            ////Console.WriteLine("Welcome " + Name + " , you are " + Age + " years old.");
            ////Console.WriteLine("Welcome {0}, you are {1} years old",Name,Age);
            //Console.WriteLine($"Welcome {Name}, you are {Age} years old");

            //------------------------------------------------------------------
            //Console.Write("Enter Number : ");
            //int N1 = Convert.ToInt32(Console.ReadLine());

            //if(N1 > 0)
            //{ 
            //    Console.WriteLine("you have entered positive number.");
            //}
            //else if(N1 < 0)
            //{
            //    //Console.WriteLine("Number is not positive");
            //    Console.WriteLine("you have entered negative number.");
            //}
            //else
            //{
            //    Console.WriteLine("Number is nethier positive nor negative.");
            //}

            //if(N1 < 0)
            //  Console.WriteLine("you have entered negative number.");

            //----------------------------------------------------------------

            Console.Write("Enter N1 : ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter N2 : ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Operator [ + - * /] : ");
            char Oprator = Console.ReadKey().KeyChar;

            Console.WriteLine();

            //if (Oprator == '+')
            //    Console.WriteLine("Result : " + (N1+N2));
            //else if (Oprator == '-')
            //    Console.WriteLine("Result : " + (N1 - N2));
            //else if (Oprator == '*')
            //    Console.WriteLine("Result : " + (N1 * N2));
            //else if (Oprator == '/')
            //    Console.WriteLine("Result : " + (N1 / N2));
            //else
            //    Console.WriteLine("Opps! Entered incorrect operator.");

            switch (Oprator)
            {
                case '+':
                    Console.WriteLine("Result : " + (N1 + N2));
                    break;
                case '-':
                    Console.WriteLine("Result : " + (N1 - N2));
                    break;
                case '*':
                    Console.WriteLine("Result : " + (N1 * N2));
                    break;
                case '/':
                    Console.WriteLine("Result : " + (N1 / N2));
                    break;
                default:
                    Console.WriteLine("Opps! Entered incorrect operator.");
                    break;
            }
        }
    }
}
