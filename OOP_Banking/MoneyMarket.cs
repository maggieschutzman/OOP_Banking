using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {
    class MoneyMarket : Account {

        public decimal monmarkrate { get; set; } = .03M;
        public decimal increasedrate { get; set; }

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
            decimal interestToBePaid =
            this.monmarkrate / 12 * months * (decimal)this.GetBalance();
            decimal intToBePaidAsDecimal = (decimal)interestToBePaid;
            this.Deposit(intToBePaidAsDecimal);
        }
        public void IncreaseInterest() {
            increasedrate = ((decimal).05 * monmarkrate) + monmarkrate;
            this.Deposit(increasedrate);
        }
    }
    }

