using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    result = result + (char) (text[i] - numbers[i]);
                }
                else
                {
                    result = result + (char)(text[i] + numbers[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
