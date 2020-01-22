using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Tyre
{
    private double degradation;

    public Tyre(double hardness)
    {
        this.Hardness = hardness;
        this.Degradation = 100;

    }

    public double Hardness { get; private set; }
    public virtual double Degradation
    {
        get { return this.degradation; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Blown Tyre");
            }
            this.degradation = value;
        }
    }
    public virtual void CompleteLap()
    {
        this.Degradation -= this.Hardness;
    }
}

