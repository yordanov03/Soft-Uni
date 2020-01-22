using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NMS
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] arr;
            StringBuilder sb = new StringBuilder();

            while (input!= "---NMS SEND---")
            {
                arr = input.ToCharArray(0, input.Length);
                for (int i = 0; i < arr.Length; i++)
                {
                    sb.Append(arr[i]);
                }
                
                input = Console.ReadLine();
                arr = null;
            }

            var separator = Console.ReadLine();
            if (separator == "(space)")
            {
                separator = " ";
            }

            StringBuilder results = new StringBuilder();
            results.Append(sb[0]);

            for (int i = 1; i < sb.Length; i++)
                
            {
                if ((sb[i]>=97 && sb[i-1]>=97 && sb[i]>=sb[i-1])|| (sb[i]<91 && sb[i-1]<91 && sb[i]>=sb[i-1]))
                {
                    results.Append(sb[i]);
                }
                else
                {
                    if (sb[i]>=97 &&sb[i]-32>=sb[i-1])
                    {
                        results.Append(sb[i]);
                    }
                    else if (sb[i]<91 && sb[i]+32>=sb[i-1])
                    {
                        results.Append(sb[i]);
                    }
                    else
                    {
                        results.Append(separator);
                        results.Append(sb[i]);
                    }
                }
            }
            Console.WriteLine(results.ToString());
        }
    }
}
