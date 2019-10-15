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
    }
}
