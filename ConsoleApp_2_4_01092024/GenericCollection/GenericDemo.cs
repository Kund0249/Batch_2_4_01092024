using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.GenericCollection
{
    class Utility
    {
        //public bool IsEqual(int n1, int n2)
        //{
        //   // bool Equal = (n1 == n2);
        //    return (n1 == n2);
        //}

        //Boxing
        //public bool IsEqual(object V1, object V2)
        //{
        //    //Unboxing
        //   dynamic value1 = V1;
        //   dynamic value2 = V2;

        //    return (value1 == value2);
        //}

        public bool IsEqual<T>(T V1, T V2)
        {
            dynamic value1 = V1;
            dynamic value2 = V2;
            return (value1 == value2);
        }
    }

    class TestGeneric<T>
    {
        public T Add(T x,T y)
        {
            dynamic v1 = x;
            dynamic v2 = y;
            return v1 + v2;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
    internal class GenericDemo
    {
        static void Main(string[] args)
        {
            //Utility utility = new Utility();
            //if(utility.IsEqual(10,20))
            //{
            //    Console.WriteLine("both values are equals.");
            //}
            //else
            //{
            //    Console.WriteLine("both values are not equals.");
            //}

            
            TestGeneric<string> testGeneric = new TestGeneric<string>();

            Console.WriteLine(testGeneric.Add("10","20"));
        }
    }
}
