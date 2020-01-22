using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string result = Revers(number);
            Console.WriteLine(result);
        }

        private static string Revers(string number)

        {
            string totalresult = "";
            for (int i =number.Length - 1  ; i >=0; i--)
            {
                totalresult += number[i];
            }
            return totalresult;
            
        }
    }
}
