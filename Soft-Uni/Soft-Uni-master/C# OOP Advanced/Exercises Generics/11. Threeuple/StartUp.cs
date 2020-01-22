using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {
        var nameAdressTown = Console.ReadLine().Split().ToList();
        var fullName = nameAdressTown[0] + " " + nameAdressTown[1];
        var adress = nameAdressTown[2];
        var town = nameAdressTown[3];

        var firstThreeuple = new Threeuple<string, string, string>(fullName, adress, town);

        var personBeerDrunk = Console.ReadLine().Split().ToList();
        var person = personBeerDrunk[0];
        var beer = int.Parse(personBeerDrunk[1]);
        bool drunk;
        drunk = personBeerDrunk[2] == "drunk";
        var secondThreeuple = new Threeuple<string, int, bool>(person, beer, drunk);

        var personCashBank = Console.ReadLine().Split().ToList();
        var name = personCashBank[0];
        var cash = double.Parse(personCashBank[1]);
        var bank = personCashBank[2];
        var thirdThreeuple = new Threeuple<string, double, string>(name, cash, bank);

        Console.WriteLine(firstThreeuple);
        Console.WriteLine(secondThreeuple);
        Console.WriteLine(thirdThreeuple);
    }
}

