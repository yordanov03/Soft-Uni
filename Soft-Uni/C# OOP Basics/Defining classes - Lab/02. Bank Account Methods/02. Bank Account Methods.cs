using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var bankAccount = new BankAccount();
        bankAccount.Id = 1;
        bankAccount.Deposit(15);
        bankAccount.Withdraw(10);
        Console.WriteLine(bankAccount);
    }
}

