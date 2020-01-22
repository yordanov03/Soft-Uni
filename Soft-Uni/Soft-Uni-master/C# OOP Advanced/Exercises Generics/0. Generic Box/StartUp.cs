using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.Generic_Box
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var box = new Box<string>();
            box.Add(input);
            Console.WriteLine(box.ToString());
        }
    }
}
