using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|","Name","CAdv","COOP","AdvOOP","Average"));

            for (int i = 0; i < numberOfRows; i++)
            {
                var inputParams = Console.ReadLine().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = inputParams[0];
                var cAdvMark = double.Parse(inputParams[1]);
                var COOP = double.Parse(inputParams[2]);
                var AdvOOP = double.Parse(inputParams[3]);
                var average = (cAdvMark + COOP + AdvOOP) / 3;

                Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",name, cAdvMark,COOP,AdvOOP,average));
            }
        }
    }
}
