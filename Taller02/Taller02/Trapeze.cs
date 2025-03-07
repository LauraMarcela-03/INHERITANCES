using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller02;

public class Trapeze : Triangle
{
    //Fields
    private double _d;

    //Constructor
    public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
    {
        Name = name;
        D = d;
    }

    //Properties
    public double D { get => _d; set => _d = ValidateD(value); }

    //Methods
    public override double GetArea()
    {
        return (B + D) * H / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }

    private double ValidateD(double d)
    {
        if (d < 0)
        {
            throw new Exception($"The d: {d}, not is valid.");
        }
        return d;
    }
}
