using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ControlStatement.JumpStatement
{
    internal class GotoStatementDemo2
    {
        static void Main(string[] args)
        {
            int i = 1;
            int n = 10;


            PrintI:
            Console.WriteLine(i);
            i++;

            if(i <= n)
               goto PrintI;
                      
            Console.WriteLine("Program End");
        }
    }
}
