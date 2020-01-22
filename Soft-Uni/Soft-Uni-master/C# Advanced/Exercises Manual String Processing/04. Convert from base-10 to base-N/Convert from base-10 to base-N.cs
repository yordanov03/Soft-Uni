using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            ulong n = ulong.Parse(input[0]);
            BigInteger baseNumber = BigInteger.Parse(input[1]);
            StringBuilder sb = new StringBuilder();

            while (baseNumber>0)
            {
                sb.Insert(0, baseNumber % n);
                baseNumber /= n;
            }

            Console.WriteLine(BigInteger.Parse( sb.ToString()));
        }
    }
}
