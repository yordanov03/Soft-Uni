using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var allTickets = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < allTickets.Count; i++)
            {
                var Ticket = allTickets[i].ToCharArray();
                var firstPartOfTicket = Ticket.Take(Ticket[0], Ticket[Ticket.Length / 2]);
                var secondPartOfTicket = Ticket.Reverse().Take(Ticket.Length / 2);
                int count1 = 0;
                int count2 = 0;

                for (int j = 1; j < firstPartOfTicket.Count()-1; j++)
                {
                 
                }
               
            }
        }
    }
}
