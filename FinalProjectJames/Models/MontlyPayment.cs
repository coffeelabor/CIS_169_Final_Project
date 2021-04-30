using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJames.Models
{
    public class MontlyPayment
    {
        //Attributes
        private double _loanAmount;
        private decimal _interestRate;
        private int _yearsOfLoan;
        private double _montlyPayment;
        public double LoanAmount
        {
            get { return _loanAmount; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Input for loan amount must be higher than $1");
                }
                _loanAmount = value;
            }
        }
        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException("Input must be between .01 and .99");
                }
                _interestRate = value;
            }
        }
        public int YearsOfLoan
        {
            get { return _yearsOfLoan; }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("Input must be 1 or greater");
                }
                _yearsOfLoan = value;
            }
        }
        public double MonthlyPayment
        {
            get { return _montlyPayment; }
        }
        //Constructor
        public MontlyPayment() { }

        public MontlyPayment(double loanAmount, decimal interestRate, int yearsOfLoan)
        {
            LoanAmount = loanAmount;
            YearsOfLoan = yearsOfLoan;
            InterestRate = interestRate;
        }
        //Methods
        public decimal GetMontlyInterestRate(decimal iRate)
        {
            int decimalPlaces = 8;
            int months = 12;
            decimal mRate;
            mRate = iRate/months;
            mRate = Decimal.Round(mRate, decimalPlaces);
            return mRate;
        }
        public int GetNumLoanLifePayments(int lYears)
        {
            int months = 12;
            int totalPayments = lYears * months;
            return totalPayments;
        }

        public double CompoundHelper()
        {
            double doubleValue = decimal.ToDouble(GetMontlyInterestRate(InterestRate));
            double compoundHelper =Math.Pow((1 + doubleValue), GetNumLoanLifePayments(YearsOfLoan));           
            return compoundHelper;
        }

        public double GetMontlyPayment()
        { 

            double doubleValue = decimal.ToDouble(GetMontlyInterestRate(InterestRate));
            double numerator= doubleValue*CompoundHelper();
            double denomitaor = CompoundHelper() -1;
            double mPayment = LoanAmount * (numerator / denomitaor);
            _montlyPayment = Math.Round(mPayment, 2);
            return _montlyPayment;
        }

        public override string ToString()
        {
            GetMontlyPayment();
            return string.Format("Montly Payment Calculator\nLoan Amount: {0:C2}\nInterest Rate: {1:P}\nLife of Loan: {2} years\nMontly Payments: {3:C2}", LoanAmount, InterestRate, YearsOfLoan, MonthlyPayment);
        }

    }
}
