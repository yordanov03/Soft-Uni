using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class LeutenantGeneral:Private,ILeutenantGeneral
    {
    public LeutenantGeneral(string id, string firstName, string lastName,double salary,List<Private> privates) : base(id, firstName, lastName, salary)
    {
        this.Privates = new List<Private>();
    }

    public List<Private> Privates { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:F2}");
        sb.AppendLine($"Privates:");
        foreach (var person in Privates)
        {
            sb.AppendLine(person.ToString());
        }

        return sb.ToString();
    }
}

