using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccounts;

namespace Bank
{
    [TestClass]
    public class BankAccountsTests
    {
        [TestMethod]     
        public void Debit_WithValidAmount_UpdateBalance()
        {
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr Been", beginningBalance);

            account.Debit(debitAmount);

            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "account not debited correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmmountIsLessThenZero_ShouldThrowArgumentOutOfRange()
        {
            double beginningBalance = 11.99;
            double debitAmount = 100.00;

            BankAccount account = new BankAccount("Mr Been", beginningBalance);

            account.Debit(debitAmount);

        }
    }
}
