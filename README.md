# CIS_169_Final_Project

Name        : CIS 169 Final Project

Author      : Reed James

Created     : 1 May 2021

Course      : CIS 169 - C#

Version     : 1.0

OS          : Windows 10

Copyright   : This is my own original work based on           
              specifications issued by our instructor

Description : Web app for calculating monthly payments
              Input: Years of Loan, Interest Rate, Loan Amount
              Output: Monthly Payment

Academic Honesty: I attest that this is my original work.
I have not used unauthorized source code, either modified or 
unmodified. I have not given other fellow student(s) access to my program.  

# User Maunal

## Setup
fork repo and clone 

open project solution

## User instructions
run program to deploy to web browser

enter data for:
1. Loan Amount (must be a number 1 or greater)
2. Interest rate (must be a number between 0 and 1 non inclusive)
3. Years of Loan (must be a number 1 or greater)
4. Montly Payment is a read only field, not data to enter


Click calculate button to calculate montly data

click clear to reset program or start over

## Code Explination
Program consists of a class 'MontlyPayment' with attributes and methods

Attibutes for: 
1.LoanAmount, InterestRate, YearsOfLoan with getters and setters 
2.MontlyPayment with a getter

Default constructor and override constructor with parameters are available

Methods include:
1. decimal GetMontlyInterestRate(decimal iRate) where interest rate is passed in and converted. Returns interest rate per month
2. int GetNumLoanLifePayments(int lYears) years is passed in and converted to months.  Returns months for loan
3. double CompundHelper() recurring part of mortgage calculation.  finds compounding component and returns result
4. double GetMontlyPayment() calls above methods and attibutes to get monthly payment amount.  sets private attribute to amount.  Returns montly payment amount
5. override string ToString() prints statement to console with values for each feild.