using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Solider:ISolider
    {
    public Solider(string id, string firstName, string lastName)
    {
        this.ID = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    public string ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

