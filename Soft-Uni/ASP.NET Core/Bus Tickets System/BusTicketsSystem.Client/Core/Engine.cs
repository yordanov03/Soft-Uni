using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Services.Interfaces;

namespace BusTicketsSystem.Client.Core
{
    public class Engine
    {
        private readonly ICommandDispatcher commandDispatcher;
        private readonly IDatabaseService databaseService;

        public Engine(ICommandDispatcher commandDispatcher, IDatabaseService databaseService)
        {
            this.commandDispatcher = commandDispatcher;
            this.databaseService = databaseService;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Command:");
                    string input = Console.ReadLine().Trim();
                    string[] data = input.Split(' ');
                    string result = this.commandDispatcher.DispatchCommand(data);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
