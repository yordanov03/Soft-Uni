using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public  class StackOfStrings
    {
    List<string> data = new List<string>();

    public bool IsEmpty()
    {
        return data.Count == 0;
    }
    public void Push(string item)
    {
        data.Add(item);
    }
    public string Pop()
    {
        string result = string.Empty;
        if (!IsEmpty())
        {
            var lastIndex = data.Count - 1;
            result = data[lastIndex];
            data.RemoveAt(lastIndex);
        }
        return result;
    }
    public string Peek()
    {
        string result = string.Empty;
        if (!IsEmpty())
        {
            result = data[data.Count - 1];
        }
        return result;
    }
    }

