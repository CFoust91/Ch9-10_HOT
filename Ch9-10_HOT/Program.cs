using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Ch9_10_HOT
{
    class Program
    {
        static void Main(string[] args)
        {

            BankLoan newLoan = new BankLoan();



            double loan;
            do
            {
                WriteLine("loan amount?");

               loan = Convert.ToInt32(ReadLine());

                newLoan.LoanAmount = loan;

                if (loan < 0)
                {
                    Console.WriteLine("Number cannot be negative");
                }
            } while (loan < 0);

            WriteLine("you entered: {0}", newLoan.LoanAmount.ToString("C"));

            newLoan.makePayment();
            WriteLine("after first payment loan is: {0}", newLoan.LoanAmount.ToString("C")); ;

            newLoan.newLoanAmount();
            WriteLine("after first payment and interest loan is: {0}", newLoan.LoanAmount.ToString("C"));


            CarLoan newCarLoan = new CarLoan();
          
            do
            {
                WriteLine("whats the dealers name?");
                newCarLoan.name = ReadLine();
                //WriteLine(newCarLoan.name);

                WriteLine("whats the loan amount for the car?");
                newCarLoan.LoanAmount = Convert.ToDouble(ReadLine());

                if (newCarLoan.LoanAmount < 0)
                {
                    Console.WriteLine("Number cannot be negative");
                }
            } while (newCarLoan.LoanAmount < 0);
            WriteLine(newCarLoan.LoanAmount);

            newCarLoan.makePayment();
            WriteLine("after first payment loan is: {0}", newCarLoan.LoanAmount.ToString("C"));

            newCarLoan.newLoanAmount();
            WriteLine("after first payment and interest loan is: {0}", newCarLoan.LoanAmount.ToString("C"));
        }
    }
   
}