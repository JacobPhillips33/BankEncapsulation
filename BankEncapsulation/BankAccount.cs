using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double depositAmount)
        {
            _balance += depositAmount;
        }

        public void Withdrawl(double withdrawlAmount)
        {
            _balance -= withdrawlAmount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
