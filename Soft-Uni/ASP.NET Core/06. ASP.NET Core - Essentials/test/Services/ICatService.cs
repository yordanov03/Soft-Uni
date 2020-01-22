using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Services
{
    public interface ICatService
    {
        IEnumerable<string> Cats { get; set; }
    }
}
