using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CustomStack<T> : IEnumerable<T>
{
    private List<T> items;

    public CustomStack()
    {
        this.items = new List<T>();
    }

    public void Push(params T[] elements)
    {
        items.AddRange(elements);
    }

    public void Pop(params T[] elements)
    {
        if (items.Count==0)
        {
            throw new ArgumentException("No elements");
        }
        items.RemoveAt(items.Count - 1);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            yield return items[i];
        }
        for (int i = items.Count - 1; i >= 0; i--)
        {
            yield return items[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

}

