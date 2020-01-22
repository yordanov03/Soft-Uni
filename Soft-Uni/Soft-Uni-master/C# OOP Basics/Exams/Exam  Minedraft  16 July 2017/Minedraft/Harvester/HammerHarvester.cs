using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class HammerHarvester:Harvester
    {
    public HammerHarvester(string id, double oreOutput, double energyRequirement):base(id, oreOutput, energyRequirement)
    {
        this.OreOutput = this.OreOutput * 3;
        this.EnergyRequirement = this.EnergyRequirement * 2;
        
    }
    public override string GetName()
    {
        return "Hammer";
    }
}

