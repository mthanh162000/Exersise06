using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnintTestAccount
    {
        [TestMethod]
        public void TestMethod1()
        {
            Account acc = new Account(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance());
        }
        [TestMethod]
        public void TestMethodWithDraw()
        {
            Account acc = new Account(500000);
            acc.Withdraw(200000);
            Assert.AreEqual(300000, acc.Balance());
            acc.Withdraw(300000);
            Assert.AreEqual(0, acc.Balance());
        }
        [TestMethod]
        public void TestMethodDeposit()
        {
            Account acc = new Account(500000);
            acc.Deposit(200000);
            Assert.AreEqual(700000, acc.Balance());
            acc.Deposit(300000);
            Assert.AreEqual(1000000, acc.Balance());
        }
        [TestMethod]
        public void TestMethodBalance()
        {
            Account acc = new Account(500000);
            acc.Deposit(200000);
            Assert.AreEqual(700000, acc.Balance());
            acc.Deposit(300000);
            Assert.AreEqual(00000, acc.Balance());
        }
    }
}
