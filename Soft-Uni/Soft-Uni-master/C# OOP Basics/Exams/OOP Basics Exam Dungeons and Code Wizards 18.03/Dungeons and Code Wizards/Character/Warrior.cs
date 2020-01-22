using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Warrior : Character, IAttackable
{
    private const int DefaultHealth = 100;
    private const int DefaultArmor = 50;

    public Warrior(string name, Faction faction) : base(name, DefaultHealth, DefaultArmor, 40, new Satchel(20), faction)
    {

    }
    public void Attack(Character character)
    {
        this.EnsureAlive();
        character.EnsureAlive();

        if (character.Name == this.Name)
        {
            throw new InvalidOperationException("Cannot attack self!");
        }
        else if (this.Faction == character.Faction)
        {
            throw new ArgumentException($"Friendly fire! Both characters are from {character.Faction} faction!");
        }
        character.TakeDamage(this.AbilityPoints);
    }
}

