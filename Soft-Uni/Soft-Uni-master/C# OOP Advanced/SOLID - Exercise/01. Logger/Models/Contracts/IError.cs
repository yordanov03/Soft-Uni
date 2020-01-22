using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }
        string Message { get; }

        ErrorLevel Level { get; }
    }
}
