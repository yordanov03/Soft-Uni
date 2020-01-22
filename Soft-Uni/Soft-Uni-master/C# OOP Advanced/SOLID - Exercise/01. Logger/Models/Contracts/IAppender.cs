using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }
        ErrorLevel Level { get; }
        void Append(IError error);
    }
}
