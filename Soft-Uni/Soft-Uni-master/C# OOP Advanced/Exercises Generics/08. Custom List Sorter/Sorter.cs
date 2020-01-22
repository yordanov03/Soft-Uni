using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Sorter

{
    public static List<string> Sort<T>(Box<T> smth) where T : IComparable<T>
    {
        var inputArray = smth.ExposedItems;

        for (int i = 0; i < inputArray.Count; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (inputArray[j - 1] > inputArray[j])
                {
                    var temp = inputArray[j - 1];
                    inputArray[j - 1] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
        }
    }
}

