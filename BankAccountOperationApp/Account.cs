using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOperationApp
{
    class Account
    {
        public string accountNumber;
        public string customerName;
        public double balance;

        public Account()
        {
            balance = 0;
        }

        public string deposit(double amount)
        {
            balance += amount;
            return amount + " Taka Has Deposited";
        }

        public string withdraw(double amount)
        {
            if (balance - amount >=0)
            {
                balance -= amount;
                return amount + " Taka Has Withdraw";
            }
            else
            {
                return "No Suficient Balance";
            }
        }
    }

    
}
