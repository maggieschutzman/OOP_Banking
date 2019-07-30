using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {
    class Checking : Account {

        private int lastCheckNumber = 0;

        public bool Pay(int CheckNumber, decimal Amount) {

            bool success = this.Withdraw(Amount);
            if (success) {
                this.lastCheckNumber = CheckNumber;
                return true;
            }
            return false;
        }
        public override string Print() {
            return base.Print() + $" | {this.lastCheckNumber}";
        }
    }        
}
