using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var ageFile = new Dictionary<string, int>();
            var salaryFile = new Dictionary<string, decimal>();
            var positionFile = new Dictionary<string, string>();

            while (line!="filter base")
            {
                var split = line.Split();
                var name = split[0];
                int secondINTParamter = 0;
                decimal secondDECIMALparameter = 0;

                if (int.TryParse(split[split.Length-1], out secondINTParamter)== true)
                {
                    ageFile[name] = secondINTParamter;
                }
                else if (decimal.TryParse(split[split.Length-1], out secondDECIMALparameter)==true)
                {
                    salaryFile[name] = secondDECIMALparameter;
                }
                else
                {
                    var secondParamter = split[split.Length - 1];
                    positionFile[name] = secondParamter;
                }

                line = Console.ReadLine();
            }
            line = Console.ReadLine();

            if (line == "Position")
            {
                foreach (var item in positionFile)
                {
                    Console.WriteLine($"Name: {item.Key}\nPosition: {item.Value}\n====================");
                }
            }

            else if (line == "Salary")
            {
                foreach (var item in salaryFile)
                {
                    Console.WriteLine($"Name: {item.Key}\nSalary: {item.Value:f2}\n====================");
                }
            }
            else if (line == "Age")
            {
                foreach (var item in ageFile)
                {
                    Console.WriteLine($"Name: {item.Key}\nAge: {item.Value}\n====================");
                }
            }
        }
    }
}
