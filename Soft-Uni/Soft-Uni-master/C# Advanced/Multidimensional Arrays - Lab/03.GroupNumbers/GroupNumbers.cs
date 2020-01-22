using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] sizes = new int[3];

            for (int i = 0; i < numbers.Count; i++)
            {
                var remainder = Math.Abs( numbers[i] % 3);
                sizes[remainder]++;
            }

            int[][] jagged = new int[3][];
            jagged[0] = new int[sizes[0]];
            jagged[1] = new int[sizes[1]];
            jagged[2] = new int[sizes[2]];

            var offsets = new int[3];
            for (int i = 0; i < numbers.Count; i++)
            {
                var reminder = Math.Abs( numbers[i] % 3);
                int index = offsets[reminder];
                jagged[reminder][index] = numbers[i];
                offsets[reminder]++;
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
