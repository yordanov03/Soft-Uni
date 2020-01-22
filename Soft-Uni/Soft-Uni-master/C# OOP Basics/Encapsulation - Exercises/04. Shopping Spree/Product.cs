﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Product
    {
    private string name;
    private decimal cost;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            this.name = value;
        }
    }
    public decimal Cost
    {
        get { return this.cost; }
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.cost = value;
        }
    }

    public Product(string name, decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }
    }

