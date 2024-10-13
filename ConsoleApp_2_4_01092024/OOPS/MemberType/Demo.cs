using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS.MemberType
{
    class Student
    {
        //Instance Member
        public int Roll { get; set; }
        public string Name { get; set; }

        public static int Count { get; set; }
        public Student()
        {
            Console.WriteLine("Default Constructor Invoked.");
            //Count = 100;
            //Count++;
        }

        static Student()
        {
            Console.WriteLine("Static Constructor Invoked.");
            //Count = 100;
        }
    }
    internal class Demo
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Roll = 1, Name = "A" };
            //Student student2 = new Student() { Roll = 1, Name = "A" };
            //Student student3 = new Student() { Roll = 1, Name = "A" };
            //Student student4 = new Student() { Roll = 1, Name = "A" };
            //Student student5 = new Student() { Roll = 1, Name = "A" };

            //Console.WriteLine(Student.Count);
        }
    }
}
