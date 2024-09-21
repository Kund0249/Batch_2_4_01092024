using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ControlStatement.IterationStatement
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int N = Convert.ToInt32(Console.ReadLine());

            int ActualValue = N;
            int reverse = 0;

            while(N > 0)
            {
                int lastdigit = N % 10;
                reverse = reverse * 10 + lastdigit;

                N = N / 10;
            }

            if(reverse == ActualValue)
            {
                Console.WriteLine("Given number is palindrome number");
            }
            else
            {
                Console.WriteLine("Given number is not palindrome number");
            }
            //Console.WriteLine("Reverse : " + reverse);

        }               
    }
}
