﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Scale <T>
        where T: IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHeavier()
        {
            if (this.right.CompareTo(this.left)>0)
            {
                return this.right;
            }
            else if (this.left.CompareTo(this.right)>0)
            {
                return this.left;
            }
            return default(T);
        }
    }

