using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Arrange_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray().ToList();
            input.Add(',');
            var results = new Dictionary<string, string>();
            StringBuilder sb = new StringBuilder();
            StringBuilder number = new StringBuilder();

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] != ',' && input[i] != ',')
                {
                    int currentNumber = input[i] - 48;

                    if (currentNumber == 0)
                    {
                        sb.Append("zero");
                        number.Append(0);
                    }
                    else if (currentNumber == 1)
                    {
                        sb.Append("one");
                        number.Append(1);
                    }
                    else if (currentNumber == 2)
                    {
                        sb.Append("two");
                        number.Append(2);
                    }
                    else if (currentNumber == 3)
                    {
                        sb.Append("three");
                        number.Append(3);
                    }
                    else if (currentNumber == 4)
                    {
                        sb.Append("four");
                        number.Append(4);
                    }
                    else if (currentNumber == 5)
                    {
                        sb.Append("five");
                        number.Append(5);
                    }
                    else if (currentNumber == 6)
                    {
                        sb.Append("six");
                        number.Append(6);
                    }
                    else if (currentNumber == 7)
                    {
                        sb.Append("seven");
                        number.Append(7);
                    }
                    else if (currentNumber == 8)
                    {
                        sb.Append("eight");
                        number.Append(8);
                    }
                    else if (currentNumber == 9)
                    {
                        sb.Append("nine");
                        number.Append(9);
                    }
                    if (input[i] != input[input.Count() - 1])
                    {
                        if (input[i + 1] == 44)
                        {
                            results.Add(number.ToString(), sb.ToString());
                            sb = new StringBuilder();
                            number = new StringBuilder();
                        }
                        else if (input[i + 1] > 47 && currentNumber < 58 && currentNumber != -16 && currentNumber != -4)
                        {
                            sb.Append("-");

                        }

                    }

                }
            }
            var ordered = results.OrderBy(x => x.Value);


            foreach (var entry in ordered)
            {
                Console.WriteLine(entry.Key + " ");
            }
        }
    }
}
