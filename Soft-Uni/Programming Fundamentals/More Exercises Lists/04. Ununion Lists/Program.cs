using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int numbersOfRows = int.Parse(Console.ReadLine());
            List<double> toBeAdded = new List<double>();
            for (int i = 0; i < numbersOfRows; i++)
            {
                var conditions = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                
                for (int j = 0; j < input.Count; j++)
                {
                    double currentNumber = input[j];
                    for (int k = 0; k < conditions.Count; k++)
                    {
                        if (input[j] == conditions[k])
                        {

                            input.RemoveAll(item => item == input[j]);
                            conditions.RemoveAll(item => item == conditions[k]);
                            j--;
                            
                        }
                    }
                    
                }
                input.AddRange(conditions);
            }
            input.Sort();
            input.Distinct();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
