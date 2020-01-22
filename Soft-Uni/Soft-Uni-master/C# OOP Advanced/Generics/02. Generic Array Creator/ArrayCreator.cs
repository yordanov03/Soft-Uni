using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ArrayCreator
    {
        public static T[] Create<T> (int lenght, T item)
        {
            var arr = new T[lenght];

            for (int i = 0; i < lenght; i++)
            {
                arr[i] = item;
            }
            return arr;
        }
    }

