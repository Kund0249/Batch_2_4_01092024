using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS.Class_Object
{

    internal class Statup
    {
        static void Main(string[] args)
        {
            //int n = 10;

            Patient patient = new Patient()
            {
                PatientId = 1,
                Name = "John",
                Gender = "M"
            };
            //patient.PatientId = 1;
            //patient.Name = "John";

            //Patient patient2 = new Patient()
            //{
            //    PatientId = 2,
            //    Name = "Ajay",
            //    Gender = "M"
            //};

            Console.WriteLine("Id : " + patient.PatientId);
            Console.WriteLine("Name : " + patient.Name);
            Console.WriteLine("Gender : " + patient.Gender);

            //Patient patient = new Patient();
            //patient.SetId(10);

            //Console.WriteLine("Id : " + patient.GetId());


        }
    }
}
