using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.GenericCollection
{
    internal class Queue_Stack_Demo
    {
        static void Main(string[] args)
        {
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            ////queue.Enqueue(6);
            //queue.Dequeue();
            //queue.Dequeue();

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            Stack<int> stact = new Stack<int>();

            stact.Push(1);
            stact.Push(2);
            stact.Push(3);
            stact.Push(4);

            Console.WriteLine("------peek------------------");
            Console.WriteLine(stact.Pop());
            //stact.Pop();
            Console.WriteLine("------peek------------------");
            Console.WriteLine(stact.Pop());

            Console.WriteLine("------peek------------------");
            Console.WriteLine(stact.Pop());

            Console.WriteLine("------peek------------------");
            Console.WriteLine(stact.Pop());

            //foreach (var item in stact)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            ////list.Insert(0, 6);
            ////list.Remove(3);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
