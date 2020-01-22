using _20._WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20._WebAPI
{
   public interface IData
    {
        IEnumerable<Cat> All();
        Cat Find(int id);
        int Add(Cat cat);
        void Delete(int id);
    }
}
