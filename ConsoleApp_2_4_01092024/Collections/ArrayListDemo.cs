using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace ConsoleApp_2_4_01092024.Collections
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            for (int i = 11; i <= 100; i++)
            {
                list.Add(i);
                list.Add("hii");
            }

            Console.WriteLine("After adding all values size of array list : " +
                 list.Count);
            Console.WriteLine("system in process....");
            Thread.Sleep(2000);

            for (int i = 51; i <= 100; i++)
            {
                list.Remove(i);

            }

            Console.WriteLine("After removing 50 elements, size of array list : " +
                 list.Count);

            Thread.Sleep(2000);

            foreach (var item in list)
            {
                if ((int)item % 2 == 0)
                    Console.WriteLine(item);
            }

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] list = new int[] { 1,2,3,4,5,6,7,8,9,10};

            //for (int i = 10; i < 100; i++) 
            //{
            //    list[i] = i+1;
            //}
        }
    }
}
