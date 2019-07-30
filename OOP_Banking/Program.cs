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

            Checking chk = new Checking();
            chk.Number = "CHK001";
            chk.Name = "My checking account";
            chk.Deposit(100);
            chk.Pay(100, 20);

            sav1.Deposit(5000);
            sav1.PayInterest(44);
            sav1.ChangeRate(0.05);

            monmar.Deposit(4000);
            monmar.Withdraw(2000);
            monmar.PayInterest(24);

            decimal mmbal = monmar.GetBalance();
            
            Account[] accounts = new Account[] { sav1, monmar, chk };

            foreach (Account acct in accounts) {
                Console.WriteLine(acct.Print());               
            }

            //bool ItWorked = monmar.TransferTo(sav1, 50);

          
        }
    }
}
