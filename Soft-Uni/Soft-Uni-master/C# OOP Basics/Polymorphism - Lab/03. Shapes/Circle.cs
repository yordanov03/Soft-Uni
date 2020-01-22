using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Circle:Shapes
    {

    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }
    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}

