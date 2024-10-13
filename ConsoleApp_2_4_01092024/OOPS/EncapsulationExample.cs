using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS
{

    public class Employee
    {
        private int _EmpCode;
        private string _EmpName;

        public Employee()
        {
            _EmpCode = 0;
        }
        //private int _Salary;

        //protected internal string test;

        public int EmpCode
        {
            set
            {
                _EmpCode = value;
            }
            get
            {
                return _EmpCode;
            }
        }

        public string EmpName
        {
            set
            {
                if (!(string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value)))
                    _EmpName = value;
                else
                    throw new Exception("Invalid inpute for priperty EmpName");
            }
            get
            {
                return _EmpName;
            }
        }

        //protected int Salary
        //{
        //    set { Salary = value; }
        //    get { return _Salary; }
        //}

        public void Method1()
        {
            Console.WriteLine("Method1 Invoked");
        }
    }

    public class Box
    {
        public int Length;
        public int Width;
        public int Height;

        public Box()
        {
            Length = 1;
            Width = 1;
            Height = 1;
        }

        public Box(int len,int wid,int hei)
        {
            Length = len;
            Width = wid;
            Height = hei;
        }

        public Box(Box box)
        {
            Length = box.Length;
            Width = box.Width;
            Height = box.Height;
        }

        public int Area()
        {
            return (Length * Width * Height);
        }
    }

    //class PaymentProcess : Employee
    //{
    //    public void CreditPaymet()
    //    {
    //        int sal = Salary;
    //    }
    //}
    internal class EncapsulationExample
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.EmpName = "John";
            //emp.EmpCode = 1;
            //emp.test = "Test";

            //Employee emp2 = new Employee()
            //{
            //    EmpCode = 2,
            //    EmpName = "Smith"
            //};
            // emp2.Salary = 1000;

            // Employee employee = new Employee();
            //bool resu = employee.Method1();

            //int n;
            //Console.WriteLine("EmpCode : " + employee.EmpCode);

            //Box b1 = new Box()
            //{
            //    Length = 10,
            //    Width = 10,
            //    Height = 10
            //};

            //Box b2 = new Box(5,10,5);

            //Console.WriteLine("Box Area B2: " + b2.Area());

            //Box b3 = new Box(b2);

            //Console.WriteLine("Box Area B3: " + b3.Area());

            Box box1 = new Box(5,5,5);
            Console.WriteLine("Length : {0}  Width : {1}  Height : {2}  Area : {3}",
                box1.Length,box1.Width,box1.Height,box1.Area());

            Console.WriteLine("-----------------------------------------------------");
            
            Box box2 = new Box(box1);//box1sal=>sallow copy
            Console.WriteLine("Length : {0}  Width : {1}  Height : {2}  Area : {3}",
               box2.Length, box2.Width, box2.Height, box2.Area());

            Console.WriteLine("------------------------------------------------------");
            box1.Length = 10;

            Console.WriteLine("Length : {0}  Width : {1}  Height : {2}  Area : {3}",
             box2.Length, box2.Width, box2.Height, box2.Area());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Length : {0}  Width : {1}  Height : {2}  Area : {3}",
               box1.Length, box1.Width, box1.Height, box1.Area());

        }
    }
}
