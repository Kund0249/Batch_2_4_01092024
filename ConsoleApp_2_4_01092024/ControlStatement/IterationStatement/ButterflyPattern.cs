using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ControlStatement.IterationStatement
{
    internal class ButterflyPattern
    {
        static void Main(string[] args)
        {
            int Start = 2;
            int space = 8;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= Start/2; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= Start / 2; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                if (i <= 4)
                {
                    Start += 2;
                    space -= 2;
                }
                else
                {
                    Start -= 2;
                    space += 2;
                }
            }
        }
    }
}
