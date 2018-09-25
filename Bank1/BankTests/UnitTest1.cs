using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
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
    }
}
