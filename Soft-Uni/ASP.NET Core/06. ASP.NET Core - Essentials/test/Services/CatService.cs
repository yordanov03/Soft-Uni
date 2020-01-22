using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Services
{
    public class CatService : ICatService
    {
        public CatService()
        {
            this.Cats = new[] { "Gosho", "Pesho" };
        }
        public IEnumerable<string> Cats { get; set ; }
    }
}
