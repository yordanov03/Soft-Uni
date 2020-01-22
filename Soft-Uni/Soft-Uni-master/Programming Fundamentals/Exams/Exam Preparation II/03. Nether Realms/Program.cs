using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Nether_Realms
{
    public class Demon
    {
        public string Name { get; set; }
        public double Health { get; set; }

        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var results = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
                var healthSymbols = demon.Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.');
                var health = 0;

                foreach (var healthSymbol in healthSymbols)
                {
                    health += healthSymbol;
                }
                var regex = new Regex(@"-?\d+\.?\d*");
                var matches = regex.Matches(demon);
                var damage = 0.0;

                foreach (Match match in matches)
                {
                    damage += double.Parse(match.Value);
                }

                var modifiers = demon.Where(s => s == '/' || s== '*');

                foreach (var modifier in modifiers)
                {
                    if (modifier== '*')
                    {
                        damage = damage * 2;
                    }

                    else
                    {
                        damage = damage / 2;
                    }
                }
                results.Add(demon, new Demon
                {
                    Health = health,
                    Damage = damage
                });
            }

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key} - {result.Value.Health} health, {result.Value.Damage} damage");
            }
        }
    }
}
