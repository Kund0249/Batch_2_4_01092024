using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ExtensionMethod
{
    public class Startup
    {
        static void Main(string[] args)
        {
            SmartCalculator smartCalculator = new SmartCalculator();
            smartCalculator.Add();
            smartCalculator.Mul(10);
        }
    }
}
