using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _05.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles("../../01_Msmsmsm");
            Console.WriteLine(string.Join("\r\n", fileNames));
            double sum = 0;

            foreach (var item in fileNames)
            {
                FileInfo Info = new FileInfo(item);
                sum += Info.Length;
            }

            Console.WriteLine(sum/1024/1024);
        }
    }
}
