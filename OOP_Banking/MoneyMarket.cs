using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {
    class MoneyMarket : Account {
    
        public double monmarkrate { get; set; } = .03;

        public override string Print() {
            return base.Print() + $" | {monmarkrate} ";
        }
        /*
                public void PayInterest(decimal amountOfInterest) {
                    this.Deposit(amountOfInterest);
                }

                public decimal CalcInterest(int months) {
                    double interestToBePaid = this.IntRate / 12 * months * (double)this.GetBalance();
                    return (decimal)interestToBePaid;
                } 

                     Combined those two to make this method     */
        public void PayInterest(int months) {
            double interestToBePaid =
            this.monmarkrate / 12 * months * (double)this.GetBalance();
            decimal intToBePaidAsDecimal = (decimal)interestToBePaid;
            this.Deposit(intToBePaidAsDecimal);

        }
     }
}
