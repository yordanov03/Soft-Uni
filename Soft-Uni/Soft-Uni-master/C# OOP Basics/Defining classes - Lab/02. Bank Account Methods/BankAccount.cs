using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class BankAccount
    {
        int id;
        decimal balance;
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
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account {Id}, balance {Balance}";
        }
    }

