using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StartUp
{
    static void Main(string[] args)
    {
        List<ISolider> everybody = new List<ISolider>();
        var input = Console.ReadLine();

        while (input != "End")
        {
            try
            {
                var separated = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (separated[0] == "Private")
                {
                    everybody.Add(new Private(separated[1], separated[2], separated[3], double.Parse(separated[4])));
                }
                else if (separated[0] == "Spy")
                {
                    everybody.Add(new Spy(separated[1], separated[2], separated[3], int.Parse(separated[4])));
                }
                else if (separated[0] == "LeutenantGeneral")
                {
                    var list = new List<Private>();
                    if (separated.Count >= 5)
                    {
                        double salary = double.Parse(separated[4]);
                        var toFind = everybody.Where(p => p.FirstName == separated[5]).FirstOrDefault();
                        list.Add(new Private(toFind.ID, toFind.FirstName, toFind.LastName,salary));
                    }
                    everybody.Add(new LeutenantGeneral(separated[1], separated[2], separated[3], double.Parse(separated[4]), list));

                }
                else if (separated[0] == "Engineer")
                {
                    var dict = new Dictionary<string, int>();
                    for (int i = 6; i < separated.Count; i += 2)
                    {
                        dict.Add(separated[i], int.Parse(separated[i + 1]));
                    }
                    everybody.Add(new Engineer(separated[1], separated[2], separated[3], double.Parse(separated[4]), separated[5], dict));

                }
                else if (separated[0] == "Commando")
                {
                    var missions = new Dictionary<string, string>();
                    for (int i = 6; i < separated.Count; i += 2)
                    {
                        missions.Add(separated[i], separated[i + 1]);
                    }

                    everybody.Add(new Commando(separated[1], separated[2], separated[3], double.Parse(separated[4]), separated[5], missions));
                }
            }
            catch (Exception)
            {

                return;
            }
            input = Console.ReadLine();
        }
    }
}

