using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Citizen : Person
{

    public Citizen(string name, int age, string id, string birthdate):base(name,age)
    {
        this.ID = id;
        this.Birthdate = birthdate;
    }

    public string ID { get; set; }
    public string Birthdate { get; set; }

    public override void BuyFood()
    {
        this.Food += 10;
    }
}

