using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger.Models
{
    using Contracts;
    public class Logger:ILogger
    {
        IEnumerable<IAppender> appenders;
        public Logger(IEnumerable<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public void Log(IError error)
        {
            foreach (IAppender appender in this.appenders)
            {
                if (appender.Level<= error.Level)
                {
                    appender.Append(error);
                }
            }
        }

    }
}
