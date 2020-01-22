using _20._WebAPI;
using _20._WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20._WebAPI
{
    public class Data1 : IData
    {
        private readonly List<Cat> data;

        public Data1()
        {
            this.data = new List<Cat>
            {
                 new Cat { Name = "Ivan", Id = 1, Age = 12, Color = "Black" },
            new Cat { Name = "Pesho", Id = 2, Age = 1, Color = "Oranj" }
            };
        }

        public int Add(Cat cat)
        {
            var id = this.data.Count + 1;
            cat.Id = id;
            this.data.Add(cat);
            return id;
        }

        public IEnumerable<Cat> All()
        {
            return new List<Cat>(this.data);
        
        }

        public void Delete(int id)
        {
            this.data.RemoveAll(c => c.Id == id);
        }

        public Cat Find(int id)
        {
            return this.All().FirstOrDefault(c => c.Id == id);
        }
    }
}


