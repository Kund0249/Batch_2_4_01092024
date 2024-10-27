using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.ExceptionHandling
{
    internal class ExceptionHandlingDemo
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();

            //string filePath = "C:\\Users\\lenovo\\source\\repos\\Batch_2_4_01092024\\ConsoleApp_2_4_01092024\\Files\\demo2.txt";
            ////string ActualPath = 

            ////if (File.Exists(filePath))
            ////{
            ////}
            //Console.WriteLine("Program completed.");
            //    StreamReader streamReader = new StreamReader(filePath);
            //    Console.WriteLine(streamReader.ReadToEnd());


            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //int res = a / b;

            try
            {
                //string filePath = "C:\\Users\\lenovo\\source\\repos\\Batch_2_4_01092024\\ConsoleApp_2_4_01092024\\Files\\demo2.txt";
                // StreamReader streamReader = new StreamReader(filePath);
                // Console.WriteLine(streamReader.ReadToEnd());
                Console.Write("Enter N1 : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter N2 : ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Res : " + (a/b));
                //
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Number can not be divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("system only accept numeric value.");
            }
            catch (Exception ex)
            {
                string filePath = "C:\\Users\\lenovo\\source\\repos\\Batch_2_4_01092024\\ConsoleApp_2_4_01092024\\Files\\demo.txt";
                 StreamWriter writer = new StreamWriter(filePath,true);
                writer.WriteLine("-------------Error : {0}-------------------",DateTime.Now.ToString());
                writer.WriteLine("Message : " + ex.ToString());
                writer.WriteLine("Trace : " + ex.StackTrace);
                writer.WriteLine("---------------------------------");
                writer.Close();


                Console.WriteLine("There is proble while processing this request, system sent this notification to the team they will soon reach out to you.");
            }
            finally
            {
                Console.WriteLine("Finally bloc invoked.");
            }
        }
    }
}
