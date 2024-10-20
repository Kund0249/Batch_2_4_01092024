using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.Collections
{
    //Input : How are you        => output : you are how.
    //Input : How are you Nitesh => output : Hwo aer yuo Nhseti.
    //Input : AAABBBCCCAA        => output : A3B3C3A2.
    internal class Startup
    {
        static void Main(string[] args)
        {
            //int[] Evennumbers = new int[] { 2, 4, 6, 8, 10, 11, 13, 15 };

            //for (int i = 0; i < Evennumbers.Length; i++)
            //{
            //    if (Evennumbers[i] % 2 != 0)
            //        Console.WriteLine(Evennumbers[i]);
            //}

            //Console.WriteLine("-----------------------------------");
            //string[,] SeatAllocation = new string[2, 2] { { "A1", "A2" }, { "B1", "B2" } };
            //for (int r = 0; r < 2; r++)
            //{
            //    for (int c = 0; c < 2; c++)
            //    {
            //        Console.Write(SeatAllocation[c,r] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            int[] EvenNumbers = new int[] { 2, 4, 6, 8, 10,2,2};
            int[] OddNumbers = new int[] { 1, 3, 5, 7, 9,11,13,15,16 };

            int[][] NumberSystems = new int[][] { EvenNumbers, OddNumbers };

            //for (int i = 0; i < numbersystems.length; i++)
            //{
            //    for (int j = 0; j < numbersystems[i].length; j++)
            //    {
            //        console.write(numbersystems[i][j] + "\t");
            //    }
            //    console.writeline();
            //}

            foreach (int[] NumsArrays in NumberSystems)
            {
                foreach (int item in NumsArrays)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
