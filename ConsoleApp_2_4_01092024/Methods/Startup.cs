using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.Methods
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            BasicCalculator basicCal = new BasicCalculator();

            //int result = basicCal.Sub(50, 20);
            //Console.WriteLine(result);

            int n = 4;

            bool result = basicCal.IsPrime(n);

            if (basicCal.IsPrime(n))
            {
                Console.WriteLine("{0} is a prime number",n);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", n);
            }
        }
    }
}
