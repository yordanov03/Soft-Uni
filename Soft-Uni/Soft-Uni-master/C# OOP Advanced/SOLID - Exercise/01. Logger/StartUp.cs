using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger
{
    using Logger.Models;
    using Logger.Models.Contracts;
    class StartUp
    {
        static void Main(string[] args)
        {
          
        }


        static ILogger InitializeLogger()
        {
            IEnumerable<IAppender> appenders = new List<IAppender>();
            int appenderCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appenderCount; i++)
            {

            }
        }
    }
}
