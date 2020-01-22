using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Commando:SpecialisedSoldier,ICommando
    {
    public Commando(string id, string firstName, string lastName, double salary, string corps, Dictionary<string,string> missions):base(id, firstName, lastName, salary, corps)
    {
        this.Missions = missions;
    }
    public Dictionary<string, string> Missions { get; set; }
    public void CompleteMission()
    {

    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {ID} Salary: {Salary:F2}");
        sb.AppendLine($"Corps: {Corps}");
        sb.AppendLine($"Missions:");

        foreach (var entry in Missions)
        {
            sb.AppendLine(entry.ToString());
        }
        return sb.ToString().Trim();
    }
}

