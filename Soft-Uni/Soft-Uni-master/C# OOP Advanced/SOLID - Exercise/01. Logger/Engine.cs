using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Logger
{
    using Models.Contracts;
    public class Engine
    {
        private ILogger logger;

        public Engine(ILogger logger)
        {
            this.logger = logger;
        }

        public void Run()
        {

        }
    }
}
