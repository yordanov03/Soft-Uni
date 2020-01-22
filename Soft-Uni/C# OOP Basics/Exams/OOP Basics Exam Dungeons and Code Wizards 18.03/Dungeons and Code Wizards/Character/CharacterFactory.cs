using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CharacterFactory
{
    public Character CreateCharacter(string[] args)
    {
        string faction =  args[0];
        string characterType = args[1];
        string name = args[2];

        Character newCharacter;

        if (faction != "CSharp" && faction != "Java")
        {
            throw new ArgumentException($"Invalid faction \"{ faction }\"!");
        }

        Faction parsedFaction;
        var toBeParsed = Enum.TryParse(faction, out parsedFaction);
        switch (characterType)
        {
            case "Warrior":
                newCharacter = new Warrior(name, parsedFaction);
                break;
            case "Cleric":
                newCharacter = new Cleric(name, parsedFaction);
                break;
            default:
                throw new ArgumentException($"Invalid character type \"{ characterType }\"!");
        }
        return newCharacter;
    }
}

