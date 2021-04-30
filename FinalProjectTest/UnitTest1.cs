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

        [Fact]
        public void TestGetMonthlyRate()
        {
            FinalProjectJames.Models.MontlyPayment mp = new FinalProjectJames.Models.MontlyPayment();
            decimal testRate = .05M;
            decimal expected = 0.004167M;
            decimal actual = mp.GetMontlyInterestRate(testRate);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestGetNumOfLoanLifePayments()
        {
            FinalProjectJames.Models.MontlyPayment mp = new FinalProjectJames.Models.MontlyPayment();
            int testYears = 30;
            int expected = 360;
            int actual = mp.GetNumLoanLifePayments(testYears);
            Assert.Equal(expected, actual);
        }

    }
}
