using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Engineer: SpecialisedSoldier, IEngeneer
    {
    public Engineer(string id, string firstName, string lastName, double salary, string corps, Dictionary<string,int> repairs) :base(id, firstName, lastName, salary, corps)
    {
        this.Repairs = repairs;
    }
    public Dictionary<string,int> Repairs { get; set; }


    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:F2}");
        sb.AppendLine($"Corps: {Corps}");
        sb.AppendLine($"Repairs:");

        foreach (var repair in Repairs)
        {
            sb.AppendLine(repair.ToString());
        }

        return sb.ToString().Trim();
    }
}

