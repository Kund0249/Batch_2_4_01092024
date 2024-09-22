using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ControlStatement.JumpStatement
{
    internal class ContinueStatement
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if(i == 6 || i == 7 || i == 8)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}
