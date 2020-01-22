using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Rectangle:Shapes
    {

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Widht = width;

    }
    public double Height { get; set; }
    public double Widht { get; set; }

    public override double CalculateArea()
    {
        return this.Height * this.Height;
    }
    public override double CalculatePerimeter()
    {
        return 2 * (this.Height + this.Widht);
    }
    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

