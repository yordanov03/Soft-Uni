using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketsSystem.Client.Core.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(params string[] data);
    }
}
