using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var command = Console.ReadLine();
        var alltrainers = new List<Trainer>();

        while (command != "Tournament")
        {
            var separated = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var currentTrainer = alltrainers.Where(t => t.name == separated[0]).FirstOrDefault();
            var pokemon = new Pokemon(separated[1], separated[2], double.Parse(separated[3]));
            
            if (currentTrainer == null)
            {
                currentTrainer = new Trainer(separated[0]);
                currentTrainer.pokemons.Add(pokemon);
                alltrainers.Add(currentTrainer);
            }
            else
            {
                currentTrainer.pokemons.Add(pokemon);
            }
            
            command = Console.ReadLine();
        }
        var element = Console.ReadLine();

        while (element!="End")
        {
            for (int i = 0; i < alltrainers.Count; i++)
            {
                var currentPokemon = alltrainers[i].pokemons.Where(p => p.element == element).FirstOrDefault();

                if (currentPokemon==null)
                {
                    for (int j = 0; j < alltrainers[i].pokemons.Count; j++)
                    {
                        alltrainers[i].pokemons[j].health -= 10;
                        if (alltrainers[i].pokemons[j].health<=0)
                        {
                            alltrainers[i].pokemons.Remove(alltrainers[i].pokemons[j]);
                        }
                    }
                }
                else
                {
                    alltrainers[i].badges++;
                }
            }


            element = Console.ReadLine();
        }

        foreach (var trainer in alltrainers.OrderByDescending(t=>t.badges))
        {
            Console.WriteLine($"{trainer.name} {trainer.badges} {trainer.pokemons.Count}");
        }
    }
}

