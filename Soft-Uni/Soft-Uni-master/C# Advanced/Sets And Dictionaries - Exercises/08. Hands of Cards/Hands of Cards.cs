using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, int>();
            var player = Console.ReadLine();

            while (player!="JOKER")
            {
                var separated = player.Split(new[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var cards = separated.Distinct().ToList();
                var name = separated[0];
                int sum = 0;

                for (int i = 1; i < cards.Count; i++)
                {
                    var currentCard = cards[i].ToCharArray();
                    var firstSymbol = currentCard[0];
                    var secondSymbol = currentCard[1];
                    var totalSum = 0;

                    if (firstSymbol=='2' || firstSymbol=='3'|| firstSymbol == '4' || firstSymbol =='5' || firstSymbol == '6' || firstSymbol == '7' || firstSymbol == '8' || firstSymbol == '9' || firstSymbol == '1')
                    {
                        if (firstSymbol=='1')
                        {
                            totalSum += 10;
                            secondSymbol = currentCard[2];
                        }
                        else
                        {
                            totalSum += (int)firstSymbol-48;
                        }
                    }
                    else if (firstSymbol=='J')
                    {
                        totalSum += 11;
                    }
                    else if(firstSymbol=='Q')
                    {
                        totalSum += 12;
                    }
                    else if (firstSymbol =='K')
                    {
                        totalSum += 13;
                    }
                    else
                    {
                        totalSum += 14;
                    }
                    if (secondSymbol=='S')
                    {
                        totalSum = totalSum * 4;
                    }
                    else if (secondSymbol=='H')
                    {
                        totalSum = totalSum * 3;
                    }
                    else if (secondSymbol=='D')
                    {
                        totalSum = totalSum * 2;
                    }
                    sum += totalSum;
                }

                if (!database.ContainsKey(name))
                {
                    database.Add(name, sum);
                }
                else
                {
                    database[name] += sum;
                }

                player = Console.ReadLine();
                sum = 0;
            }

            foreach (var item in database)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
