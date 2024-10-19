using Modle;
using Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS.Abstraction
{
    public class StudentPage
    {
        //private readonly IStudentProcessor _studentProcessor;

        //public StudentPage()
        //{
        //    _studentProcessor = new StudentProcessor();
        //}

        static void Main(string[] args)
        {
            StudentModel student = new StudentModel()
            {
                RollNo = 1,
                Name = "Test",
            };
            //_studentProcessor.Save(student);
            IStudentProcessor _studentProcessor = new StudentProcessor();
            _studentProcessor.Save(student);
        }


    }
}
