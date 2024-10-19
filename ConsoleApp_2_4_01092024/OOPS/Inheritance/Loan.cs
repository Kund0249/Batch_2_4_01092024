using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS.Inheritance
{
    internal abstract class Loan
    {
        public string AccountNumber { get; set; }
        public string LoanHolderName { get; set; }

        public int LoanAmount { get; set; }
        public int Tenure { get; set; }
        public float ROI { get; set; }

        public void GetEMIPlan()
        {
            //
        }

        public bool IsEligible()
        {
            return true;
        }

        public abstract void ProcessLoan();
    }
}
