using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Provider
{
    private string id;
    private double energyOutput;

    protected Provider(string id, double energyOutput)
    {
        this.ID = id;
        this.EnergyOutput = energyOutput;
    }
    public string ID
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
            }
            this.energyOutput = value;
        }
    }
    public abstract string GetName();

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.GetName()} Provider - {this.ID}")
            .Append($"Energy Output: {this.EnergyOutput}");

        return sb.ToString();
    }

}

