using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Shapes
    {
    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
    public virtual string Draw()
    {
        var result = "Drawing ";
        return result;
    }
    }

