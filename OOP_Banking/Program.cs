using System;

namespace OOP_Banking {
    class Program {
        static void Main(string[] args) {
            Account acct = new Account();
            acct.Number = "1001";
            acct.Name = "Test Account";
            acct.Deposit(20);
            acct.Withdraw(10);
            decimal  balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (Should be 10)");
            acct.Deposit(-10);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (Should be 10)");
            acct.Withdraw(20);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (Should be 10)");


        }
    }
}
