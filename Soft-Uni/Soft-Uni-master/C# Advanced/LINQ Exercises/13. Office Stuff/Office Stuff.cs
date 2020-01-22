using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Office_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfInput = int.Parse(Console.ReadLine());
            var data = new List<Supplies>();

            for (int i = 0; i < numberOfInput; i++)
            {
                var separated = Console.ReadLine().Split(new[] { ' ', '|','-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                data.Add(new Supplies { Company = separated[0], quantity = int.Parse(separated[1]), type = separated[2] });
            }

            var grouped = data.GroupBy(x => x.Company).ToDictionary(s => s.Key, s=>s.ToList());

            foreach (var item in grouped)
            {
                Console.Write($"{item.Key}: ");

                var groupedValues = item.Value.GroupBy(x=>)

                foreach (var entry in item.Value)
                {
                    Console.Write(string.Join(", ", $"{entry.type} - {entry.quantity} \n"));
                }
            }

        }
    }
}
