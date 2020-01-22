using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Jedi_Meditation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var masters = new List<string>();
            var knights = new List<string>();
            var padawan = new List<string>();
            var idiots = new List<string>();
            bool yoda = false;


            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < input.Count; j++)
                {
                    if (input[j].StartsWith("y"))
                    {
                        yoda = true;
                    }
                    else if (input[j].StartsWith("m"))
                    {
                        masters.Add(input[j]);
                    }
                    else if (input[j].StartsWith("k"))
                    {
                        knights.Add(input[j]);
                    }
                    else if (input[j].StartsWith("p"))
                    {
                        padawan.Add(input[j]);
                    }
                    else
                    {
                        idiots.Add(input[j]);
                    }
                }
            }
            if (yoda==true)
            {
                Console.Write(string.Join(" ",masters)+" ");
                Console.Write(string.Join(" ", knights) + " ");
                Console.Write(string.Join(" ", idiots) + " ");
                Console.Write(string.Join(" ", padawan));
            }
            else
            {
                Console.Write(string.Join(" ", idiots) + " ");
                Console.Write(string.Join(" ", masters) + " ");
                Console.Write(string.Join(" ", knights) + " ");
                Console.Write(string.Join(" ", padawan));
            }
        }
    }
}
