using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class UltrasoftTyre:Tyre
    {
    public UltrasoftTyre(double hardness,double grip) : base(hardness)
    {
        this.Grip = grip;
    }
    public double Grip { get; set; }
    public override double Degradation
    {
        get => base.Degradation;
        set
        {
           
            base.Degradation = value;
        }
    }
    public override void CompleteLap()
    {
        base.CompleteLap();

        this.Degradation -= this.Grip;
        if (this.Degradation < 30)
        {
            throw new ArgumentException("Blown Tyre");
        }
    }
}

