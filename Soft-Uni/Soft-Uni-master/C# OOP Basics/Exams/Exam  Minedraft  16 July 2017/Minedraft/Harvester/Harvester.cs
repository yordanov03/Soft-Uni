using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.ID = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public string ID
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput");
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value < 0|| value>=20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement");
            }
            this.energyRequirement = value;
        }
    }
    public abstract string GetName();
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.GetName()} Harvester - {this.ID}")
            .AppendLine($"Ore Output: {this.OreOutput}")
            .Append($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString();
    }
}

