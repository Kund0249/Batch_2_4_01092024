using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_2_4_01092024.OOPS;

namespace ConsoleApp2
{
    internal class Program : Employee
    {
        static void Main(string[] args)
        {
            Program program = new Program()
            {
                test = "test"
            };
        }
    }
}
