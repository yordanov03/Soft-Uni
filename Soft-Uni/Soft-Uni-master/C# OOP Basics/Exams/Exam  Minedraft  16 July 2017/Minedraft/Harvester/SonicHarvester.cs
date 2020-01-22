﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SonicHarvester : Harvester
{
    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement = this.EnergyRequirement / this.SonicFactor;


    }
    public int SonicFactor
    {
        get { return this.sonicFactor; }
        protected set { this.sonicFactor = value; }

    }
    public override string GetName()
    {
        return "Sonic";
    }
}

