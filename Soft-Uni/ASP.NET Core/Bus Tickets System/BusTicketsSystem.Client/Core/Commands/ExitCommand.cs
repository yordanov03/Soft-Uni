using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketsSystem.Client.Core.Commands.Contracts
{
    public class ExitCommand : ICommand
    {
        public string Execute(params string[] data)
        {
            Environment.Exit(0);
            return null;
        }
    }
}
