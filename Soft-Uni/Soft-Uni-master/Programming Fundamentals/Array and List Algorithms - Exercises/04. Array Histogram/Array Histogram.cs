using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            List<string> word = new List<string>();
            List<double> counter = new List<double>();

            int singleCounter = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (word.Contains(input[i]))
                {

                }
                else
                {
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (!word.Contains(input[i]))
                        {
                            word.Add(input[i]);
                            singleCounter++;
                        }

                        else if (input[j] == input[i])
                        {
                            singleCounter++;

                        }

                    }
                    counter.Add(singleCounter);
                    singleCounter = -1;
                }
                
            }

            double allCounter = 0;

            for (int i = 0; i < counter.Count; i++)
            {
                allCounter += counter[i];
            }

            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 1; i < counter.Count; i++)
                {
                    if (counter[i].CompareTo(counter[i-1])==1)
                    {
                        var tempcounter = counter[i-1];
                        counter[i-1] = counter[i];
                        counter[i] = tempcounter;

                        swapped = true;

                        var tempword = word[i-1];
                        word[i-1] = word[i];
                        word[i] = tempword;
                    }
                }
            } while (swapped ==true);

            List<double> percentage = new List<double>();

            for (int i = 0; i < counter.Count; i++)
            {
                percentage.Add(Math.Round((counter[i] / allCounter) * 100,2));
            }

            for (int i = 0; i < word.Count; i++)
            {
                Console.WriteLine($"{word[i]} -> {counter[i]} times ({percentage[i]}%)");
            }
        }
    }
}
