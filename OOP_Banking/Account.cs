using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Banking {
    public class Account {
        public string Number { get; set; }
        private decimal Balance { get; set; } = 0;
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        public void Deposit(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine($"Deposit amount must be GT zero.");
            }
            else {
                this.Balance += Amount;          
            }            
        }
        public void Withdraw(decimal Amount) {
            if (Amount <= 0) {
            Console.WriteLine($"Withdraw amount must be GT zero.");
            }
            else {
            if (this.Balance >= Amount) {
                this.Balance -= Amount;
            }
        }
    }
        public decimal GetBalance() {
             return this.Balance;
        }
    }

  }


