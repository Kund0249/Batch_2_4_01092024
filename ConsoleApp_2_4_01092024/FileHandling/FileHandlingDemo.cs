using System;
using System.Data;
using System.IO;

namespace ConsoleApp_2_4_01092024.FileHandling
{
    internal class FileHandlingDemo
    {
        static void Main(string[] args)
        {
            //DateTime.Now.ToString("ddMMyyyy")
           
            string basepath = @"C:\Users\lenovo\source\repos\Batch_2_4_01092024\ConsoleApp_2_4_01092024";
            string directoryName = $"Invoices-{DateTime.Now.ToString("ddMMyyyy")}";
            string direcotorypath = Path.Combine(basepath, directoryName);
            string fileName = "Invoice.txt";
            string filePath = Path.Combine(direcotorypath,fileName);

            //Code to creat the folder
            //if (!Directory.Exists(direcotorypath))
            //{
            //    Directory.CreateDirectory(direcotorypath);
            //}

            //code to create the file
            //if (!File.Exists(filePath))
            //{
            //    File.Create(filePath);
            //}
            //else
            //{
            //    File.Delete(filePath);
            //}

            //code to write to the file.

            //StreamWriter writer = new StreamWriter(filePath,true);
            //writer.WriteLine("Below is your invoice details\n");
            //writer.WriteLine("ITEM \t  Discription \t Price \n");
            //for (int i = 1; i <= 5; i++)
            //{
            //    writer.WriteLine($"Item-{i} \t Discription-{i} \t {i*100} \n");
            //    writer.WriteLine("-----------------------------------------\n");
            //}
            //writer.Close();

            //if (File.Exists(filePath))
            //{
            //    StreamReader sr = new StreamReader(filePath);

            //    var alldata = sr.ReadToEnd();
            //    Console.WriteLine(alldata);

            //    Console.WriteLine("Process Completed!");
            //}
            //else
            //{
            //    Console.WriteLine("File not found.");
            //}
           
            //Random random = new Random();
            //int OTP = random.Next(111111,999999);
            //Console.WriteLine("OTP - " + OTP);

        }
    }
}
