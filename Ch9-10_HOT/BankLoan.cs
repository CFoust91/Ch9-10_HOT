using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch9_10_HOT
{
    class BankLoan
    {
        public double LoanAmount { get; set; }
        private readonly double INTEREST = .05;
        public double interest
        {
            get
            {
                return INTEREST;
            }
        }

       public virtual double makePayment()
        {
            LoanAmount = LoanAmount - 200;
            return LoanAmount;
        }
       public double newLoanAmount()
        {


            double newAmount = LoanAmount * interest;
            LoanAmount += newAmount;
          
            return LoanAmount;
        }
       
    }
    class CarLoan : BankLoan
    {
        public string name { get; set; }


        public override double makePayment()
        {
            LoanAmount = LoanAmount - 450;
            return LoanAmount;
        }
    }
}


