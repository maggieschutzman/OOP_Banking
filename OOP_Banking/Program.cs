using System;

namespace OOP_Banking {
    class Program {
        static void Main(string[] args) {


            Savings sav1 = new Savings();
            sav1.Number = "SAV001";
            sav1.Name = "My Money Market Account";

            MoneyMarket monmar = new MoneyMarket();
            monmar.Number = "MM001";
            monmar.Name = "Money Market";
            monmar.monmarkrate = 0.3;

            Account[] accounts = new Account[] { sav1, monmar };

            foreach (Account acct in accounts) {
                Console.WriteLine(acct.Print());

            }

            Console.WriteLine(sav1.Print());
            Console.WriteLine(monmar.Print());
            /*
                        bool ItWorked = monmar.TransferTo(sav1, 50);
                        Console.WriteLine($"Money Market balance is {monmar.GetBalance()}");
                        Console.WriteLine($"Saving1 balance is {sav1.GetBalance()}");

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


                        MoneyMarket monmar = new MoneyMarket();
                        monmar.Number = "1003";
                        monmar.Name = "Money Market";
                        monmar.monmarkrate = 0.3;

                        monmar.Deposit(500);
                        monmar.Withdraw(100);
                        monmar.PayInterest(24);
                        decimal mmbal = monmar.GetBalance();
                        Console.WriteLine($"Money Market balance is {mmbal}");

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
