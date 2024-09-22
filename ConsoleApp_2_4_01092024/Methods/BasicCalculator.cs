using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.Methods
{
    internal class BasicCalculator
    {
        //access-specifiers return-type method-Name([parameters])
        //{
            // method body (executable code)
        //}

        public int Add(int V1, int V2)
        {
            //int sum = V1 + V2;
            //return sum;
            return V1 + V2;
        }

        public int Sub(int V1, int V2)
        {
            return V1 - V2;
        }
        public bool IsPrime(int N)
        {
            for (int i = 2; i < (N / 2 + 1); i++)
            {
                if (N % i == 0)
                    return false;
            }

            return true;
        }
    }
}
