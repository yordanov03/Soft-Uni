using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Nature_s_Prophet
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dimensions = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[][] garden = new int[dimensions[0]] [];

            for (int i = 0; i < dimensions[0]; i++)
            {
                garden[i] = new int[dimensions[0]];

                for (int j = 0; j < dimensions[1]; j++)
                {
                    garden[i][j] = 0;
                }
            }
            input = Console.ReadLine();

            while (input!= "Bloom Bloom Plow")
            {
                var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                if (separated[0]<dimensions[0] && separated[0]>=0 && separated[1]<dimensions[1] && separated[1]>=0)
                {
                    garden[separated[0]][separated[1]] = 1;

                    for (int k = separated[0]+1; k < dimensions[0]; k++)
                    {
                        garden[k][separated[1]]++;
                    }
                    for (int k = separated[0] - 1; k >= 0; k--)
                    {
                        garden[k][separated[1]]++;
                    }
                    for (int l = separated[1]+1; l < dimensions[1]; l++)
                    {
                        garden[separated[0]][l]++;
                    }
                    for (int l = separated[1] - 1; l >= 0; l--)
                    {
                        garden[separated[0]][l]++;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var row in garden)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
