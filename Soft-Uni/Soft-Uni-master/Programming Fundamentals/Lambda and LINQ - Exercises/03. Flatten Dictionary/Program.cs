using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, Dictionary<string, string>>();
            var line = Console.ReadLine();

            while (line != "end" || line.Contains("flatten"))
            {
                var split = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var type = split[0];
                var brand = split[1];
                var model = split[2];

                if (line!="flatten")
                {
                    if (!database.ContainsKey(type))
                    {
                        database[type] = new Dictionary<string, string>();
                    }
                    else
                    {
                        database[type][brand] = model;
                    }
                    
                }
                else
                {

                }
            }
        }
    }
}
