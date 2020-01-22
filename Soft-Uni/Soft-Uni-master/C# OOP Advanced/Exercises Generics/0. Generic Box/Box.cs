using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Box<T>
    {
    private List<T> items;
    public Box()
    {
        this.Value = default(T);
    }

    public T Value { get; set; }
    public void Add(T element)
    {
        this.items.Add(element);
    }
    public override string ToString()
    {
        return $"{typeof(T).FullName}: {string.Join("", this.items)}";
    }
}

