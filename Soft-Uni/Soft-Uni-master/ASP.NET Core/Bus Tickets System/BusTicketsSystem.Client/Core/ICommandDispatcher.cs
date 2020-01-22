using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicketsSystem.Client.Core
{
    public interface ICommandDispatcher
    {
        string DispatchCommand(string[] commandParameters);
    }
}
