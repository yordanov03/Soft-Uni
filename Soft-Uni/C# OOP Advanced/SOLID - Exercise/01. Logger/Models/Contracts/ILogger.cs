using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models.Contracts
{
    public interface ILogger
    {
        void Log(IError error);
    }
}
