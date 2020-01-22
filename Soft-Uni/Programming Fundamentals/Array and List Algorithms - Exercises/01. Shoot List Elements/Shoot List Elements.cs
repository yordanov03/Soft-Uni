using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialCommand = Console.ReadLine();
            List<double> numbers = new List<double>();
            double lastRemoved = 0;
            List<double> removed = new List<double>();


            while (initialCommand != "stop")
            {
                if (initialCommand != "bang")
                {
                    double converted = double.Parse(initialCommand);
                    numbers.Insert(0, converted);
                }
                else
                {
                    if (numbers.Count > 0)
                    {
                        double average = numbers.Average();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= average)
                            {
                                lastRemoved = numbers[i];
                                removed.Add(numbers[i]);
                                numbers.Remove(numbers[i]);
                                for (int j = 0; j < numbers.Count; j++)
                                {
                                    numbers[j]--;
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}", lastRemoved);
                    }
                }
                initialCommand = Console.ReadLine();
            }

            if (initialCommand == "stop")
            {
                if (numbers.Count <= 0)
                {
                    for (int i = 0; i < removed.Count; i++)
                    {
                        Console.WriteLine("shot {0}", removed[i]);
                    }
                    Console.WriteLine("you shot them all. last one was {0}", lastRemoved);
                }

                else
                {
                    for (int i = 0; i < removed.Count; i++)
                    {
                        Console.WriteLine("shot {0}", removed[i]);
                    }
                    Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
                }
            }
        }
    }
}
