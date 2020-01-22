using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Rebel:Person
    {

    public Rebel(string name, int age, string group):base(name,age)
    {

        this.Group = group;
    }
    public string Group { get; set; }

    public override void BuyFood()
    {
        this.Food += 5;
    }
    }

