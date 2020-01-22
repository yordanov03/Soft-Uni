using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cleric : Character, IHealable
{
    public Cleric(string name, Faction faction) : base(name, 50, 25, 40, new Backpack(100), faction)
    {

    }
    public override double RestHealMultiplier => 0.5;
    public void Heal(Character character)
    {
        this.EnsureAlive();
        character.EnsureAlive();

        if (character.Faction != this.Faction)
        {
            throw new InvalidOperationException("Cannot heal enemy character!");
        }

        character.Health += this.AbilityPoints;
    }
}

