using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int days = int.Parse(Console.ReadLine());
            input.Add(int.MaxValue);

            for (int i = 0; i < days; i++)
            {
                for (int j = 1; j < input.Count-1; j++)
                {
                    input[j - 1]++;
                    if (input[j]>input[j-1] && input[j]>input[j+1])
                    {
                        input[j - 1]--;
                        input[j + 1]--;
                        input[j]++;
                    }
                    else if (input[j]<=input[j-1] && input[j]<=input[j+1])
                    {
                        input[j]--;
                    }
                    else if (input[j]>input[j-1] && input[j]<input[j+1])
                    {
                        input[j]--;
                    }
                    else
                    {
                        input[j]++;
                    }
                }
            }
            input.Remove(int.MaxValue);
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]<=days)
                {
                    input.Remove(input[i]);
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
