using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Item
{
    public Item(int weight)
    {
        this.Weight = weight;
    }
    public int Weight { get; set; }

    public virtual void AffectCharacter(Character character)
    {
        character.EnsureAlive();
    }
}

