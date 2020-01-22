using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            byte[] unibyte = Encoding.Unicode.GetBytes(input);
            StringBuilder sb = new StringBuilder();

            foreach (var b in unibyte)
            {
                if (b != 0)
                {
                    sb.Append("\\u");
                    sb.Append(string.Format("{0:x4}", (int)b));
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
