using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS.Abstraction
{
    internal interface IStudentRepo
    {
        void ProcessReport();
    }

    internal interface IStaffRepo
    {
        void ProcessReport();
    }

    class ReportProcessor : IStaffRepo, IStudentRepo
    {
        //public void ProcessReport()
        //{
        //    Console.WriteLine("Student Report Generated and sent over email.");
        //}
        void IStudentRepo.ProcessReport()
        {
            Console.WriteLine("Student Report Generated and sent over email.");

        }

        void IStaffRepo.ProcessReport()
        {
            Console.WriteLine("Staff Report Generated and sent over email.");

        }
    }

    class Startup
    {
        static void Main(string[] args)
        {
            ReportProcessor reportProcessor = new ReportProcessor();
            //reportProcessor.ProcessReport();

            //IStaffRepo repo = new ReportProcessor();

            //repo.ProcessReport();
           ((IStudentRepo)reportProcessor).ProcessReport();

            ((IStaffRepo)reportProcessor).ProcessReport();
        }
    }
}
