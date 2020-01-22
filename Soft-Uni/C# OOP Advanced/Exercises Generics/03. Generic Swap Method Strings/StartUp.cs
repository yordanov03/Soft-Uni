using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_Swap_Method_Strings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var box = new List<Box<string>>();
            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine();
                box.Add(new Box<string>(input));
            }

            var positions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var temp = box[positions[0]];
            box[positions[0]] = box[positions[1]];
            box[positions[1]] = temp;

            foreach (var item in box)
            {
                Console.WriteLine(item);
            }

        }
    }
}
