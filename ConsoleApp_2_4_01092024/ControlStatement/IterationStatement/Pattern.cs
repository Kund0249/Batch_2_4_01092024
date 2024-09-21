using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ControlStatement.IterationStatement
{
    internal class Pattern
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 4; i++) 
            //{ 
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //-------------------------------------------------
            //   *
            //  ***
            // *****
            //*******

            //int space = 3;
            //int patternStart = 1;

            //for (int i = 1; i <= 4; i++)
            //{
            //    for(int s = 1; s <= space; s++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int p = 1; p <= patternStart; p++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //    space--;
            //    //patternStart += 2;
            //    patternStart = patternStart + 2;
            //}


            //-------------------------------------------------
            //   *
            //  *@*
            // *@*@*
            //*@*@*@*

            //int space = 3;
            //int patternStart = 1;

            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int s = 1; s <= space; s++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int p = 1; p <= patternStart; p++)
            //    {
            //        if (p % 2 == 0)
            //            Console.Write("@");
            //        else
            //            Console.Write("*");
            //    }

            //    Console.WriteLine();
            //    space--;
            //    //patternStart += 2;
            //    patternStart = patternStart + 2;
            //}


            //-------------------------------------------------
            //   *
            //  * *
            // *   *
            //*******

            int space = 3;
            int patternStart = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int s = 1; s <= space; s++)
                {
                    Console.Write(" ");
                }

                for (int p = 1; p <= patternStart; p++)
                {
                    if (i == 4 || p == 1 || p == patternStart)
                        Console.Write("*");
                    else 
                        Console.Write(" ");
                }

                Console.WriteLine();
                space--;
                //patternStart += 2;
                patternStart = patternStart + 2;
            }
        }
    }
}
