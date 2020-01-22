using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box<T>
    where T:IComparable<T>
{
    private List<T> items;
    public Box()
    {
        this.items = new List<T>();
    }

    public void Add(T input)
    {
        this.items.Add(input);
    }

    public int Count { get; set; }

    public int CompareAll(T criteria)
    {
        for (int i = 0; i < this.items.Count; i++)
        {
            if (this.items[i].CompareTo(criteria)==1)
            {
                this.Count++;
            }
        }
        return this.Count;
    }
}

