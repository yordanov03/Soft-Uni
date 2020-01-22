using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', '.').Select(int.Parse).ToList();
            List<char> leftPart = new List<char>();
            List<char> rightPart = new List<char>();
            List<char> result = new List<char>();

            for (int i = 0; i < input.Count; i += 2)
            {
                var temp = input[i];
                temp = Convert.ToChar(input[i]);
                leftPart.Add((char)temp);
            }
            for (int i = 1; i < input.Count; i += 2)
            {
                var temp = input[i];
                temp = Convert.ToChar(input[i]);
                rightPart.Add((char)input[i]);
            }
            rightPart.Reverse();

            result.AddRange(leftPart);
            result.AddRange(rightPart);

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i]=='\0')
                {
                    result.Remove(result[i]);
                    i--;
                }
            }

            Console.WriteLine(string.Join("", result));
        }

      
    }
}
