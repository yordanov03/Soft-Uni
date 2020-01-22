using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new HashSet<string>();

            while (input!="PARTY")
            {
                list.Add(input);
                input = Console.ReadLine();
            }

            while (input!="END")
            {
                if (list.Contains(input))
                {
                    list.Remove(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(list.Count);

            var results = new SortedSet<string>(list);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
