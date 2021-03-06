﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Box
    {
    private double length;
    private double width;
    private double height;

    public Box(double length, double width,double height)
    {
        
        this.Lenght = length;
        this.Width = width;
        this.Heigth = height;
    }

    
    public double Lenght
    {
        get { return this.length; }
        private set
        {
            if (value<=0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    public double Width
    {
        get { return this.width; }
        private set
        {
            if (value<=0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }
    public double Heigth
    {
        get { return this.height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }
    public double SurfaceArea()
    {
        return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
    }
    public double LateralSurfaceArea()
    {
        return 2 * this.length * this.height + 2 * this.width * this.height;
    }
    public double Volume()
    {
        return this.length * this.width * this.height;
    }
    }

