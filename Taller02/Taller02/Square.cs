using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller02;

public class Square : GeometricFigure
{
    //Fields
    private double _a;

    //Constructor
    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    //Properties
    public double A { get => _a; set => _a = ValidateA(value); }

    //Methods
    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    private double ValidateA(double a)
    {
        if (a < 0)
        {
            throw new Exception($"The a: {a}, not is valid");
        }
        return a;
    }
}
