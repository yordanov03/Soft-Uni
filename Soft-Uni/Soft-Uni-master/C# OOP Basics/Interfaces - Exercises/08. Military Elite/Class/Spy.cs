using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Spy:Solider,ISpy
    {
    public Spy(string id, string firstName, string lastName, int codeNumber):base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }
    public int CodeNumber { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id:{ID}");
        sb.AppendLine($"Code Number: {CodeNumber}");
        return sb.ToString().Trim(); ;
    }
}

