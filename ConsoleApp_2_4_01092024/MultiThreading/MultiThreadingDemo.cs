using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.MultiThreading
{
    public delegate bool NumberPrintLogicDel(int n);
    static class MyClass
    {
        public static void Fun3(NumberPrintLogicDel del)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(del.Invoke(i))
                Console.WriteLine(i);
            }
        }
        public static void Function1()
        {
            Console.WriteLine("Washing Start...");
            Thread.Sleep(1000);
            Console.WriteLine("20% Washe...");
            Thread.Sleep(1000);
            Console.WriteLine("40% Washe...");
            Thread.Sleep(1000);
            Console.WriteLine("60% Washe...");
            Thread.Sleep(1000);
            Console.WriteLine("80% Washe...");
            Thread.Sleep(1000);
            Console.WriteLine("Washed!");
        }

        public static void Function2()
        {
            Console.WriteLine("Cooking Start...");
            Thread.Sleep(1000);
            Console.WriteLine("20% Cook...");
            Thread.Sleep(1000);
            Console.WriteLine("40% Cook...");
            Thread.Sleep(1000);
            Console.WriteLine("60% Cook...");
            Thread.Sleep(1000);
            Console.WriteLine("80% Cook...");
            Thread.Sleep(1000);
            Console.WriteLine("Food ready!");
        }
    }
    internal class MultiThreadingDemo
    {
        static void Main(string[] args)
        {
            //MyClass.Function1();
            //MyClass.Function2();

            Thread washingThread = new Thread(MyClass.Function1);
            Thread cookingThread = new Thread(MyClass.Function2);
           
            washingThread.Start();
            cookingThread.Start();

            washingThread.Join();
            cookingThread.Join();
            Console.WriteLine("All work done");

        }
    }
}
