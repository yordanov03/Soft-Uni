using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ArmorRepairKit : Item
{
    public ArmorRepairKit() : base(10) { }

    public override void AffectCharacter(Character character)
    {
        base.AffectCharacter(character);
        character.Armor = character.BaseArmor;
    }

}