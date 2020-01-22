using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box<T>
where T : IComparable<T>
{
    private List<T> items;

    public Box()
    {
        this.items = new List<T>();

    }

    public List<T> ExposedItems
    {
        get { return this.items; }
    }
    public int Count { get; set; }

    public void Add(T element)
    {
        this.items.Add(element);
    }

    public T Remove(int index)
    {
        var removedItem = this.items[index];
        this.items.RemoveAt(index);
        return removedItem;
    }

    public bool Contains(T element)
    {
        return this.items.Contains(element);
    }

    public void Swap(int index1, int index2)
    {
        var temp = this.items[index1];
        this.items[index1] = this.items[index2];
        this.items[index2] = temp;
    }
    public int CountGreaterThan(T element)
    {
        Count = 0;
        for (int i = 0; i < this.items.Count; i++)
        {
            if (this.items[i].CompareTo(element) > 0)
            {
                Count++;
            }
        }

        return Count;
    }
    public T Max()
    {
        return this.items.Max();
    }
    public T Min()
    {
        return this.items.Min();
    }

    public void Sort()
    {
        this.items = this.items.OrderBy(i => i).ToList();

    }


    public override string ToString()
    {
        var sb = new StringBuilder();

        foreach (var item in this.items)
        {
            sb.Append(item);
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
