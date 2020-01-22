using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();  
            int count = 1;
            

            for (int i = input.Length - 1; i > 0; i--)
            {
                
                    if (input[i] == input[i-1])
                    {
                    count++;
                        if (count==3)
                        {
                        Console.WriteLine("{0} {0} {0}", input[i]);
                            break;
                        }
                       
                    }
                else
                {
                    count = 1;
                }
                
            }

            


            
        }
    }
}
