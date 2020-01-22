using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            bool swapped = false;

            while (swapped==false)
            {
                swapped = true;
            
            for (int i = 1; i < input.Count; i++)
            {
               
                if (input[i-1].CompareTo(input[i])==1)
                {
                    var temp = input[i-1];
                    input[i-1] = input[i];
                    input[i] = temp;
                    swapped = false;
                }
           
            }
            }
            if (swapped==true)
            {
                Console.WriteLine(string.Join(" ",input));
            }
            
        }
    }
}
