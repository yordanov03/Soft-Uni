﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Store
    {
        public Store()
        {

        }

        public Store(string name)
        {
            this.Name = name;
        }

        public int StoreId { get; set; }
        public string Name { get; set; }
        public Sale Sales { get; set; }
    }
}
