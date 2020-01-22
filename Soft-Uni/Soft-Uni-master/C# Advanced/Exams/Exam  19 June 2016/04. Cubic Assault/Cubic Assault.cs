using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Cubic_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string,BigInteger>>();
            var input = Console.ReadLine();

            while (input!= "Count em all")
            {
                var separated = input.Split(new[] {" -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var region = separated[0];
                var meteorType = separated[1];
                BigInteger amount = BigInteger.Parse(separated[2]);

                if (!data.ContainsKey(region))
                {
                    data[region] = new Dictionary<string, BigInteger> { { "Red", 0 }, { "Green", 0 }, { "Black", 0 } };
                }
                    data[region][meteorType] += amount;

                if (meteorType=="Green" && data[region][meteorType]>=1000000)
                {
                   BigInteger remainder =  data[region][meteorType] / 1000000;
                    data[region][meteorType] = data[region][meteorType] - (remainder * 1000000);
                    meteorType = "Red";
                    data[region][meteorType] += remainder;
                }
                if (meteorType=="Red" && data[region][meteorType]>=1000000)
                {
                    BigInteger remainder = data[region][meteorType] / 1000000;
                    data[region][meteorType] = data[region][meteorType] - (remainder * 1000000);
                    meteorType = "Black";
                    data[region][meteorType] += remainder;
                }
                input = Console.ReadLine();
            }

            foreach (var region in data.OrderByDescending(x=>x.Value["Black"]).ThenBy(x=>x.Key.Length).ThenBy(x=>x.Key))
            {
                Console.WriteLine(region.Key);

                foreach (var rock in region.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"-> {rock.Key} : {rock.Value}");
                }
            }

            
        }
    }
}
