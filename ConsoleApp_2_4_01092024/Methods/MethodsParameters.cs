using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.Methods
{
    internal class MethodsParameters
    {
        public int sum(int v1,int v2,params int[] values)
        {
            int sum = v1 + v2;

            foreach(int n in values)
            {
                sum += n;               
            }

            return sum;
        }
        public bool ConvertToInt(string inputvalue, out int outputvalue)
        {
            try
            {
                int convertedvalue = Convert.ToInt32(inputvalue);
                outputvalue = convertedvalue;
                return true;
            }
            catch (Exception)
            {
                outputvalue = 0;
                return false;
            }
        }

        public int RectangleCal(int length, int width, out int Paremeters)
        {
            int Area = length * width;
            Paremeters = 2 * (length + width);

            return Area;
        }
        public void IncrementCounter(ref int counter)
        {
            counter++;
            //counter = 1;
            Console.WriteLine("Counter value inside method - " + counter);

        }


        public List<string> GetAvailableSeat(DateTime bookingDate,bool isWindow = false)
        {
            //logic
            if(isWindow)
            {
                //check for windows seats only;
            }
            return new List<string>() { "101", "102" };
        }

        //public void Test(int a,int b,int c = 0)
        //{

        //}
    }

    class MethodsParametersStartup
    {
        static void Main(string[] args)
        {
             MethodsParameters ob = new MethodsParameters();

            // //int counter = 0;
            // //ob.IncrementCounter(ref counter);

            // //Console.WriteLine(counter);

            // int length = 10;
            // int width = 5;
            //// int paremeters;
            // int Area =  ob.RectangleCal(length, width,out int paremeters);

            // Console.WriteLine("Area : " + Area);
            // Console.WriteLine("Paremeter : " + paremeters);

            //string n = "1014";
            ////int number = Convert.ToInt32(n);

            //if (ob.ConvertToInt(n, out int number))
            //    Console.WriteLine(number);
            //else
            //    Console.WriteLine("Invalid value");

            //ob.GetAvailableSeat(DateTime.Now,true);

            int total = ob.sum(10,20,5,5,5,5,5,5);
            Console.WriteLine(total);
        }
    }
}
