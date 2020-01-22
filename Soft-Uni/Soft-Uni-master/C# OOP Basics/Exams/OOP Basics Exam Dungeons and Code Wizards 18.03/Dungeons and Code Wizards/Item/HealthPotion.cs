using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class HealthPotion:Item
    {
    public HealthPotion() : base(5) { }
    public override void AffectCharacter(Character character)
    {
        base.AffectCharacter(character);
        character.Health += 20;
    }
}

