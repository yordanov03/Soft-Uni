using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Bag
{
    private readonly List<Item> items;
    private int capacity;
    public Bag(int capacity = 100)
    {
        this.Capacity = capacity;
        this.items = new List<Item>();

    }

    public int Capacity
    {
        get
        {
            return this.capacity;
        }
        set
        {
            this.capacity = value;
        }
    }
    public IReadOnlyCollection<Item> Items => this.items.AsReadOnly();
    public int Load
    {
        get
        {
            return items.Sum(i => i.Weight);
        }
    }


    public void AddItem(Item item)
    {
        if ((this.Capacity - this.Load) < item.Weight)
        {
            throw new InvalidOperationException("Bag is full!");
        }
        items.Add(item);
    }
    public Item GetItem(string name)
    {
        if (this.items.Count==0)
        {
            throw new InvalidOperationException("Bag is empty!");
        }
        var searchedItem = items.Where(i => i.GetType().Name == name).FirstOrDefault();

        if (searchedItem == null)
        {
            throw new ArgumentException($"No item with name {name} in bag!");
        }
        return searchedItem;
    }
    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }
}

