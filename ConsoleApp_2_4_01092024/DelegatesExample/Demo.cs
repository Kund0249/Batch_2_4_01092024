using ConsoleApp_2_4_01092024.MultiThreading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.DelegatesExample
{
    //ref type
    public delegate void MyDelegate();
    internal class Demo
    {
        static void Main(string[] args)
        {
            //MyClass.Function1();
            MyDelegate @delegate = new MyDelegate(MyClass.Function1);

            //NumberPrintLogicDel del = new NumberPrintLogicDel((n) =>
            //{
            //    if (n % 2 != 0)
            //        return true;
            //    return false;
            //});
            //@delegate.Invoke();
            // MyClass.Fun3(del);

            MyClass.Fun3(x => x <= 10 && x % 2 == 0);

            //MyClass.Fun3(50);
        }
    }
}
