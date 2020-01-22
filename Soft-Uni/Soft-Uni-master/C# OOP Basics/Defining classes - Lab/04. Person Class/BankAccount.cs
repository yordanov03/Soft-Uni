﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class BankAccount
    {
        private int id;
        private decimal balance;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance<amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= amount;
            }
            
        }
        public override string ToString()
        {
            return $"Account ID{Id}, balance {Balance:f2}";
        }
    }

