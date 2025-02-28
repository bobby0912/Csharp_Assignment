//**Encapsulation Challenge**

//Create a `BankAccount` class where `balance` is a private field.Implement methods for `Deposit()`
//and `Withdraw()`, ensuring that withdrawal is only allowed if there is a sufficient balance.Prevent
//direct modification of `balance` from outside the class.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    class BankAccount
    {
        private decimal balance;

        public BankAccount()
        {
            balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew: {amount}. New balance: {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance for withdrawal.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        BankAccount account = new BankAccount();
    //        account.Deposit(100);
    //        account.Withdraw(50);
    //        account.Withdraw(100);
    //        account.Deposit(-50);
    //        account.Withdraw(100);
    //        Console.WriteLine($"Current balance: {account.GetBalance():C}");
    //    }
    //}
}
