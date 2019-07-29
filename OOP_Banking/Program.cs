using System;

namespace OOP_Banking {
    class Program {
        static void Main(string[] args) {

            Savings sav = new Savings();
            sav.Number = "1002";
            sav.Name = "Savings 1";
            sav.IntRate = 0.1;

            sav.Deposit(200);
            sav.Withdraw(100);
            decimal interestToBePaid = sav.CalcInterest(3);
            sav.PayInterest(interestToBePaid);
            decimal savbal = sav.GetBalance();
            Console.WriteLine($"Savings balance is {savbal}");

  /* 
            Account acct = new Account();
            acct.Number = "1001";
            acct.Name = "Test Account";

            acct.Deposit(20);
            acct.Withdraw(10);
            decimal balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (Should be 10)");

            acct.Deposit(-10);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (Should be 10)");

            acct.Withdraw(20);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (Should be 10)");

  */
        }
    }
}
