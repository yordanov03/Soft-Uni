using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Private:Solider,IPrivate
    {
    public Private(string id,string firstName, string lastName, double salary):base(id,firstName,lastName)
    {
        this.Salary = salary;
    }
    public double Salary { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:F2}");
        return sb.ToString();
    }
}

