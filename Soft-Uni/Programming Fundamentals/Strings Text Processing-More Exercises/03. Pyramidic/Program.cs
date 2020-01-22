using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pyramidic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> pyramids = new List<string>();
            string[] lines = new string [n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string currentine = lines[i];

                for (int j = 0; j < currentine.Length; j++)
                {
                    char curretCharecter = currentine[j];
                    int layer = 1;
                    string currentPyramid = "";
                    for (int k = i; k < lines.Length; k++)
                    {
                        string currentLayer = new string(curretCharecter, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }
                        layer += 2;
                    }
                    pyramids.Add(currentPyramid.Trim());
                }
            }
            Console.WriteLine(pyramids.OrderByDescending(x=>x.Length).First());
        }
    }
}
