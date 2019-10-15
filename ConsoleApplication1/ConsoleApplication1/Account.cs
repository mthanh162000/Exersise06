using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    public class Account
    {
        private int money;
        public Account(int amount)
        {
            money = amount;
        }
        public void Deposit(int amount)
        {
            money += amount;
        }
        public void Withdraw(int amount)
        {
            money -= amount;
        }
        public int Balance()
        {
            return money;
        }

    }
}
