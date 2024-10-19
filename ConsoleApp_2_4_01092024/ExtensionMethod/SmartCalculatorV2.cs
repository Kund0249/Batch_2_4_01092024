using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ExtensionMethod
{
    public static class SmartCalculatorV2
    {
        public static void Mul(this SmartCalculator calculator,int value)
        {
            Console.WriteLine("Multiple method Invoked - " + value);
        }
    }
}
