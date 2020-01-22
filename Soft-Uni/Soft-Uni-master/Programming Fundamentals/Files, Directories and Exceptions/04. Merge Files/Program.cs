using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = File.ReadAllLines("input1.txt");
            string[] text2 = File.ReadAllLines("input2.txt");

            for (int i = 0; i < text1.Length; i++)
            {
                File.AppendAllText("results.txt", text1[i]+ "\r\n");
                File.AppendAllText("results.txt", text2[i] + "\r\n");
            }
        }
    }
}
