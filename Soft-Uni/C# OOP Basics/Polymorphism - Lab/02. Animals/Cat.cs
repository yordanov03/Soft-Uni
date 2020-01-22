using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Cat:Animal
    {
    public Cat(string name, string favouroiteFood) : base(name, favouroiteFood)
    {

    }
    public override string ExplainSelf()
    {
        return base.ExplainSelf() + "MEEOW";
    }
}

