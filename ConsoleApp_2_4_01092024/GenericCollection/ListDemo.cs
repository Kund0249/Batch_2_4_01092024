using ConsoleApp_2_4_01092024.GenericCollection;
using ConsoleApp_2_4_01092024.OOPS.Polymorphism;
using System;
using System.Collections.Generic;


namespace ConsoleApp_2_4_01092024.GenericCollection
{
    //class StudentEqualityComparer : IEqualityComparer<Student>
    //{
    //    public bool Equals(Student x, Student y)
    //    {
    //        if(x.Roll == y.Roll && x.Name == y.Name)
    //            return true;

    //        return false;
    //    }

    //    public int GetHashCode(Student obj)
    //    {
    //        return (obj.Roll.ToString() + obj.Name).GetHashCode();
    //    }
    //}

    class TransactionDetail
    {
        public DateTime TransactionData { get; set; }
        public int AvailableBalance { get; set; }
        public int TotalCredited { get; set; }
        public int TotalDebited { get; set; }
    }

    class EmployeeEquilityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            if (x.EmpId == y.EmpId && x.Name == y.Name)
                return true;

            return false;
        }

        public int GetHashCode(Employee obj)
        {
            return (obj.EmpId.ToString() + obj.Name).GetHashCode();
        }
    }

    internal class ListDemo
    {
        static void Main(string[] args)
        {
            //Student s = new Student()
            //{
            //  Roll = 1,
            //  Name = "Test",
            //};

            //HashSet<Employee> list = new HashSet<Employee>(new EmployeeEquilityComparer());

            //list.Add(new Employee() { EmpId = 1, Name = "A" });
            //list.Add(new Employee() { EmpId = 2, Name = "B" });
            //list.Add(new Employee() { EmpId = 1, Name = "A" });
            //list.Add(new Employee() { EmpId = 2, Name = "C" });


            //foreach (var item in list)
            //{
            //    Console.WriteLine("Roll : {0} Name : {1}",item.EmpId, item.Name);
            //}

            //string Name = "test";
            //Console.WriteLine("Hashcode for test : " + Name.GetHashCode());

            //string N = "10";
            //Console.WriteLine("Hashcode of 10 : " + N.GetHashCode());

            Dictionary<string, TransactionDetail> transactionInfor = new Dictionary<string, TransactionDetail>();

            transactionInfor.Add("MH001", new TransactionDetail()
            {
                TransactionData = DateTime.Now,
                AvailableBalance = 1009208303,
                TotalCredited = 32673673,
                TotalDebited = 356356
            });

            transactionInfor.Add("MH002", new TransactionDetail()
            {
                TransactionData = DateTime.Now,
                AvailableBalance = 1009208303,
                TotalCredited = 253656,
                TotalDebited = 27637627
            });
            transactionInfor.Add("DL001", new TransactionDetail()
            {
                TransactionData = DateTime.Now,
                AvailableBalance = 1009208303,
                TotalCredited = 565652,
                TotalDebited = 2563623
            });

            //foreach (var item in transactionInfor)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine("---------------Start-----------------------");
            //    Console.WriteLine("Transaction Date : " + item.Value.TransactionData);
            //    Console.WriteLine("Total Debited : " + item.Value.TotalDebited);
            //    Console.WriteLine("Total Credited : " + item.Value.TotalCredited);
            //    Console.WriteLine("Available : " + item.Value.AvailableBalance);
            //    Console.WriteLine("---------------End-----------------------");
            //    Console.WriteLine();
            //}


            var transaction = transactionInfor["DL001"];

            if (transaction != null)
            {
                Console.WriteLine("---------------Start-----------------------");
                Console.WriteLine("Transaction Date : " + transaction.TransactionData);
                Console.WriteLine("Total Debited : " + transaction.TotalDebited);
                Console.WriteLine("Total Credited : " + transaction.TotalCredited);
                Console.WriteLine("Available : " + transaction.AvailableBalance);
                Console.WriteLine("---------------End-----------------------");
            }
        }
    }

}

