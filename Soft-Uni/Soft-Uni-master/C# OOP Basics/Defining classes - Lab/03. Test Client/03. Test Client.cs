using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();
            var command = Console.ReadLine();

            while (command!="End")
            {
                var separated = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string action = separated[0];
                int accountId = int.Parse(separated[1]);

                switch (separated[0])
                {
                    case "Create":
                        if (accounts.ContainsKey(accountId))
                        {
                            Console.WriteLine("Account already exists");
                        }
                        else
                        {
                            accounts.Add(accountId, new BankAccount { Id = accountId });
                        }
                        break;

                    case "Deposit":
                        if (validateAccountExistance(accountId,accounts))
                        {
                            accounts[accountId].Deposit(decimal.Parse(separated[2]));
                        }
                        break;

                    case "Withdraw":
                        if (validateAccountExistance(accountId,accounts))
                        {
                            accounts[accountId].Withdraw(decimal.Parse(separated[2]));
                        }
                        break;
                    case "Print":
                        if (validateAccountExistance(accountId, accounts))
                        {
                            Console.WriteLine(accounts[accountId]);
                        }
                            break;
                    default:
                        break;
                        
                }
                command = Console.ReadLine();
            }
        }
        static bool validateAccountExistance(int accountId, Dictionary<int, BankAccount> accounts)
        {
            if (accounts.ContainsKey(accountId))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Account does not exist");
                return false;
            }
        }
    }
    

