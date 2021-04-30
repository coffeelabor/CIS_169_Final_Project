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
        //Methods
        public decimal GetMontlyInterestRate(decimal iRate)
        {
            int decimalPlaces = 6;
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


    }
}
