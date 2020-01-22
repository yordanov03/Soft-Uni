using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Room
{
    public Pet SickPet { get; set; }

    public override string ToString()
    {
        if (this.SickPet is null)
        {
            return $"Room empty";
        }
        else
        {
            return this.SickPet.ToString();
        }
    }


}

