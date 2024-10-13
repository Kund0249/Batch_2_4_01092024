using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS.Polymorphism
{
    internal class EmailService
    {
        public int Add(int N1,int N2)
        {
           return 0;
        }

        public int Add(int N1, int N2,int N3)
        {
            return 0;
        }
        public float Add(float N1, int N2)
        {
            return 0.0F;
        }

        public float Add(int N1, float N2)
        {
            return 0.0F;
        }
        public void Send(string From,string To,string Content)
        {
            //code to send email
        }

        public int Send(string From, string To,string CC, string Content)
        {
            //code to send email
            return 0;
        }

        public void Send(string From, string To, string Content,byte[] Attachement)
        {
            //code to send email
        }

        public void Send(string From, string To, string Content,string CC, byte[] Attachement)
        {
            //code to send email
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();

            emailService.Add(10, 10);
        }
    }
}
