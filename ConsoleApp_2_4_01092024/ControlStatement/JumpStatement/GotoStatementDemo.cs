using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ControlStatement.JumpStatement
{
    internal class GotoStatementDemo
    {
        static void Main(string[] args)
        {
            char NeedToContinue;
            do
            {
                Console.Write("Enter N1 : ");
                int N1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter N2 : ");
                int N2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Operator [ + - * /] : ");
                //this is a lable
                CalOperator:
                char Oprator = Console.ReadKey().KeyChar;

                Console.WriteLine();

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
                        Console.Write("Enter a valid operator : ");
                        goto CalOperator;
                        break;
                }

                Console.Write("To continue press y : ");
                NeedToContinue = Console.ReadKey().KeyChar;
                NeedToContinue = char.ToLower(NeedToContinue);

                Console.WriteLine();
            } while (NeedToContinue == 'y');
        }
    }
}
