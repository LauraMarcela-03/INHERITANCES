using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller02;

public class Circle : GeometricFigure
{
    //Fields
    private double _r;

    //Constructor
    public Circle(string name, double r)
    {
        Name = name;
        R = r;
    }

    //Properties
    public double R { get => _r; set => _r = ValidateR(value); }

    //Methods
    public override double GetArea()
    {
        return Math.PI * Math.Pow (R, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    private double ValidateR(double r)
    {
        if (r < 0)
        {
            throw new Exception($"The r: {r}, not is valid.");
        }
        return r;
    }
}
