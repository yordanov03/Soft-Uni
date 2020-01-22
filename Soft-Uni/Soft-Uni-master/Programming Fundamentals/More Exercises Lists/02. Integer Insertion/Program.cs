using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            string initialCommand = Console.ReadLine();

            while (initialCommand!="end")
            {
               
                var firstNumber = initialCommand.ToList();
                int positionForInsert = firstNumber[0]-48;
                input.Insert(positionForInsert,initialCommand);
                initialCommand = Console.ReadLine();
                
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
