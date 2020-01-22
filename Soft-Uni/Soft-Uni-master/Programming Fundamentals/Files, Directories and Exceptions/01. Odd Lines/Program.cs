using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] originalFile = File.ReadAllLines("input.txt");

            for (int i = 1; i < originalFile.Length; i+=2)
            {
                File.AppendAllText("output.txt", originalFile[i] +"\r\n");
            }
        }
    }
}
