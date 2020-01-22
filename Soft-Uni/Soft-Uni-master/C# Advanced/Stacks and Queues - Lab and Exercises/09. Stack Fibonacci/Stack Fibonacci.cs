﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();
            stack.Push(1);
            stack.Push(1);
            stack.Push(1);

            for (int i = 3; i <= n; i++)
            {
                var minusOne = stack.Pop();
                var minusTwo = stack.Peek();
                stack.Push(minusOne);

                var currentFibonacci = minusOne + minusTwo;
                stack.Push(currentFibonacci);
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
