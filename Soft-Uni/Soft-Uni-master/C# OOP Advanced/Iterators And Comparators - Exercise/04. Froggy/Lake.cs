﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Lake : IEnumerable<int>
{
    private List<int> stones;
    public Lake(params int[] numbers)
    {
        this.stones = new List<int>(numbers);
    }

    public IEnumerator<int> GetEnumerator() 
    {
        for (int i = 0; i < stones.Count; i++)
        {
            if (i%2==0)
            {
                yield return stones[i];
            }
        }
        for (int i = stones.Count - 1; i >= 0; i--)
        {
            if (i % 2 != 0)
            {
                yield return stones[i];
            }
        }
    }
   IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

