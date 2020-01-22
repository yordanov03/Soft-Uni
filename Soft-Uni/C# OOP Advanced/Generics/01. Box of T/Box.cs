using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Box <T>
    {
        private Stack<T> items;
        public Box()
        {
            this.items = new Stack<T>();
        }

        public void Add(T element)
        {
            items.Push(element);
        }

        public T Remove()
        {
           var removedItem =  items.Pop();
            return removedItem;
        }

    public int Count => items.Count();
    }

