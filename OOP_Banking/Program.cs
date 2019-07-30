using System;

namespace OOP_Banking {
    class Program {
        static void Main(string[] args) {

            Savings sav1 = new Savings();
            sav1.Number = "SAV001";
            sav1.Name = "My Savings Account";
            sav1.IntRate = 0.1;

            MoneyMarket monmar = new MoneyMarket();
            monmar.Number = "MM001";
            monmar.Name = "My Money Market Account";
            monmar.monmarkrate = .03M;

            sav1.Deposit((decimal)5000);
            sav1.PayInterest(44);
            sav1.ChangeRate(0.05);

            monmar.Deposit((decimal)4000);
            monmar.Withdraw((decimal)2000);
            monmar.PayInterest(24);

            decimal mmbal = monmar.GetBalance();
            
            Account[] accounts = new Account[] { sav1, monmar };


            foreach (Account acct in accounts) {
                Console.WriteLine(acct.Print());               
            }

            //bool ItWorked = monmar.TransferTo(sav1, 50);

            //Console.WriteLine(sav1.Print());
            //Console.WriteLine(monmar.Print());

            //Console.WriteLine($"Money Market balance is {monmar.GetBalance()}");
            //Console.WriteLine($"Saving1 balance is {sav1.GetBalance()}");

            //Savings sav = new Savings();
            //sav.Number = "1002";
            //sav.Name = "Different Savings";
            //sav.IntRate = 0.1;

            //sav.Deposit((decimal)10000);
            //sav.Withdraw((decimal)100);
            //decimal interestToBePaid = sav.CalcInterest(3);
            //sav.PayInterest(interestToBePaid);
            //decimal savbal = sav.GetBalance();
            //Console.WriteLine($"Savings balance is {savbal}");


            //monmar = new MoneyMarket();
            //monmar.Number = "1003";
            //monmar.Name = "Money Market";
            //monmar.monmarkrate = 0.3;

            //monmar.Deposit((decimal)4000);
            //monmar.Withdraw((decimal)100);
            //monmar.PayInterest(24);
            //decimal mmbal = monmar.GetBalance();
            //Console.WriteLine($"Money Market balance is {mmbal}");

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
