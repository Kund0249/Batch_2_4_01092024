using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ControlStatement.IterationStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("This is Iteration Example");
            //Console.WriteLine("This is Iteration Example");
            //Console.WriteLine("This is Iteration Example");
            //Console.WriteLine("This is Iteration Example");
            //Console.WriteLine("This is Iteration Example");

            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.WriteLine("This is Iteration Example");
            //}

            int N = 4;
            bool IsPrime = true;

            for (int i = 2; i < N/2; i++)
            {
                //break;
                //for (int j = 1; j < N; j++)
                //{
                   
                //}

                if (N % i == 0)
                {
                    IsPrime = false;
                    break;
                }

            }

            if (IsPrime) 
            {
                Console.WriteLine("{0} is a prime number",N);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", N);
            }
        }
    }
}
