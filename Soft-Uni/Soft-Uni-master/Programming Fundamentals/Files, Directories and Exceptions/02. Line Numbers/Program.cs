using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            int count = 1;

            for (int i = 0; i < input.Length; i++)
            {
                File.AppendAllText("output.txt", count+"." + input[i] + "\r\n");
                count++;
            }
        }
    }
}
