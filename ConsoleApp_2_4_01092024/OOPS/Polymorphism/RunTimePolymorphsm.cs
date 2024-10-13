using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS.Polymorphism
{
    class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }


        public override string ToString()
        {
            return string.Format("Roll No. : {0}, Name : {1}", this.Roll, this.Name);
        }
    }
    internal class RunTimePolymorphsm
    {
        static void Main(string[] args)
        {
            //object
            //int n = 10;

            //Console.WriteLine(n.ToString()+10);
            Student student = new Student()
            {
                Roll=1,
                Name = "A"
            };

            Console.WriteLine(student.ToString());
        }
    }
}
