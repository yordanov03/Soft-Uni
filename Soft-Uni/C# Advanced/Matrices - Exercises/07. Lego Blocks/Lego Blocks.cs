using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int BlockToBeJoined = int.Parse(Console.ReadLine());
            long[][] firstPair = new long[BlockToBeJoined][];
            long[][] secondPair = new long[BlockToBeJoined][];
            long[][] results = new long[BlockToBeJoined][];
            int index = 0;
            bool areEqual = true;

            for (int i = 0; i < BlockToBeJoined; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
                firstPair[i] = new long[inputLine.Count];
                for (int j = 0; j < inputLine.Count; j++)
                {
                    firstPair[i][j] = inputLine[j];
                }
            }


            for (int i = 0; i < BlockToBeJoined; i++)
            {
                secondPair[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).Reverse().ToArray();
            }


            for (int i = 0; i < BlockToBeJoined; i++)
            {
                results[i] = new long[firstPair[i].Length  + secondPair[i].Length];
                for (int j = 0; j < firstPair[i].Length; j++)
                {
                    results[i][j] = firstPair[i][j];
                }
                for (int k = firstPair[i].Length; k <firstPair[i].Length+secondPair[i].Length ; k++)
                {
                    results[i][k] = secondPair[i][index];
                    index++;
                }
                index = 0;
            }

            int resultLenght= results[0].Length;

            for (int i = 1; i < BlockToBeJoined; i++)
            {
                if (resultLenght!=results[i].Length)
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual==true)
            {
                foreach (var row in results)
                {
                    Console.WriteLine("[{0}]", string.Join(", ",row));
                }
            }
            else
            {
                Console.WriteLine("The total number of cells is: {0}",results.Sum(x => x.Length));
            }
        }
    }
}
