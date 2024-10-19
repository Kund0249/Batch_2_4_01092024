using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2_4_01092024.OOPS.Inheritance
{
    internal class GoldLoan : Loan
    {
        public int NumberOfAurnament { get; set; }
        public float GoldWeight { get; set; }
        public float CurrentMarketRatePerGram { get; set; }
        public float GivenRatePerGrame { get; set; }
        public float EligibleAmount { get; set; }
        public float ClaimedAmount { get; set; }

        public override void ProcessLoan()
        {
            //logic
        }
    }
}
