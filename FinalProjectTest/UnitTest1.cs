using System;
using Xunit;
using FinalProjectJames;

namespace FinalProjectTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestLoanAmountLessThanOne()
        {
            FinalProjectJames.Models.MontlyPayment mp = new FinalProjectJames.Models.MontlyPayment();
            int lessThanOne = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => mp.LoanAmount = lessThanOne);
        }

        [Fact]
        public void TestInterestRateLessThanZero()
        {
            FinalProjectJames.Models.MontlyPayment mp = new FinalProjectJames.Models.MontlyPayment();
            decimal lessThanOne = -.01M;
            Assert.Throws<ArgumentOutOfRangeException>(() => mp.InterestRate = lessThanOne);
        }

        [Fact]
        public void TestInterestRateGreaterThanNineNine()
        {
            FinalProjectJames.Models.MontlyPayment mp = new FinalProjectJames.Models.MontlyPayment();
            int greaterThanNineNine = 1;
            Assert.Throws<ArgumentOutOfRangeException>(() => mp.InterestRate = greaterThanNineNine);
        }

        [Fact]
        public void TestYearsOfLoanLessThanOne()
        {
            FinalProjectJames.Models.MontlyPayment mp = new FinalProjectJames.Models.MontlyPayment();
            int lessThanOne = 0;
            Assert.Throws<ArgumentOutOfRangeException>(() => mp.YearsOfLoan = lessThanOne);
        }
    }
}
