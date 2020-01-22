using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] arr;

            arr = input.ToCharArray(0,input.Length);
            StringBuilder sb = new StringBuilder(input.Length);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sb.Append(arr[i]);
            }

            Console.WriteLine(sb.ToString());




        }
    }
}
