using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.A_Miner_s_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourse = Console.ReadLine();
            var amoount = decimal.Parse(Console.ReadLine());
            var treasury = new Dictionary<string, decimal>();

            while (resourse != "stop")
            {
                if (treasury.ContainsKey(resourse))
                {
                    treasury[resourse] += amoount;
                }
                else
                {
                    treasury.Add(resourse, amoount);
                }
                resourse = Console.ReadLine();
                if (resourse != "stop")
                {
                    amoount = decimal.Parse(Console.ReadLine());
                }


            }

            foreach (var item in treasury)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
