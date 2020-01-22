using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Vehicle
{
    private int capacity;
    private readonly List<Product> trunk;
    private bool isFull;
    private bool isEmpty;

    public Vehicle(int capacity)
    {
        this.Capacity = capacity;
        this.trunk = new List<Product>();
    }
    public int Capacity
    {
        get { return this.capacity; }
        set { this.capacity = value; }
    }
    public  IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();
    public bool IsFull
    {
        get { return this.isFull; }
        set
        {
            if (this.Trunk.Sum(p=>p.Weight)>=this.Capacity)
            {
                value = true;
            }
            else
            {
                value = false;
            }
            this.isFull = value;
        }
    }
    public bool IsEmpty
    {
        get { return this.isEmpty; }
        set
        {
            if (!this.Trunk.Any())
            {
                value = true;
            }
            else
            {
                value = false;
            }
            this.isEmpty = value;
        }
    }

    public void LoadProduct(Product product)
    {
        if (this.IsFull==true)
        {
            throw new InvalidOperationException("Vehicle is full!");
        }

        this.isEmpty = false;
        if (this.Trunk.Count>this.Capacity)
        {
            return;
        }
        trunk.Add(product);
       
    }
    public Product Unload()
    {
        if (this.IsEmpty==true)
        {
            throw new InvalidOperationException("No products left in vehicle!");
        }
        Product productToRemove = this.trunk.Last();
        this.trunk.Remove(productToRemove);
        return productToRemove;
    }

}

