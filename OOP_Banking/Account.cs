using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {
    public class Account {
        public string Number { get; set; }
        private decimal Balance { get; set; } = 0;
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        public decimal GetBalance() {
            return this.Balance;
        }

        public virtual string Print() {
            return $"{this.Number} | {this.Balance} | {this.Name}";
        }

        public bool TransferTo(Account ToAccount, decimal Amount) {
            bool success = this.Withdraw(Amount);
            if (success) {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
        }

        public bool Deposit(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine($"Deposit amount must be GT zero.");
            }
            else {
                this.Balance += Amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine($"Withdraw amount must be GT zero.");
                return false;
            }
            else {
                if (this.Balance >= Amount) {
                    this.Balance -= Amount;
                    return true;
                }
                return false;
            }
        }
        //public void Deposit(double Amount) {
        //    if (Amount <= 0) {
        //        Console.WriteLine($"Deposit amount must be GT zero.");
        //    }
        //    else {
        //        this.Balance += (decimal)Amount;
        //    }
        }



        }
        // change return from void to bool for transfer

        /// <summary>
        /// Make a withdraw
        /// </summary>
        /// <param name="Amount">The amount you want </param>
        public void Withdraw(float Amount) {
            if (Amount <= 0) {
                Console.WriteLine($"Withdraw amount must be GT zero.");
            }
            else {
                if (this.Balance >= (decimal)Amount) {
                    this.Balance -= (decimal)Amount;
                }

            }
        }



    }
}