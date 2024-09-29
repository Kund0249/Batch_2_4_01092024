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
        public bool ProcessDate(out int processId)
        {
            //code to process the data.

            processId = 1056;
            return true;
        }
        static void Main(string[] args)
        {
            MethodsParametersStartup ob = new MethodsParametersStartup();
            //int Pid = 0;
            bool IsProcessSuccefull =  ob.ProcessDate(out int Pid);

            Console.WriteLine("Is Process Completed : " + IsProcessSuccefull);
            Console.WriteLine("Process Id : " + Pid);
        }
    }
}
