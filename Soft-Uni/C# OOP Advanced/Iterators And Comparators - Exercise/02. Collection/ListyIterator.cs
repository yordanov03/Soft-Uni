using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ListyIterator<T>:IEnumerable<T>
{
    private List<T> items;
    private int currentIndex = 0;

    public ListyIterator(params T[] elements)
    {
        this.items = new List<T>();

        if (elements.Length!=0)
        {
            this.items.AddRange(elements);
        }
    }

    public bool Move()
    {
        if (++currentIndex < this.items.Count)
        {
            return true;
        }
        return false;
    }
    public T Print()
    {
        if (this.items.Count == 0)
        {
            throw new ArgumentException($"Invalid Operation!");
        }
        return this.items[currentIndex];

    }
    public bool HasNext()
    {
        if (currentIndex == this.items.Count - 1)
        {
            return false;
        }
        return true;
    }

    public string PrintAll()
    {
        if (this.items.Count != 0)
        {
            return string.Join(" ", this.items);
        }
        throw new ArgumentException("Invalid Operation!");
    }
    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in this.items)
        {
            yield return item;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

