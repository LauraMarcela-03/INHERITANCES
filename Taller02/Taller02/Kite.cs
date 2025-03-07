using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller02;

public class Kite : Rhombus
{
    //Fields
    private double _b;

    //COnstructor
    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        Name = name;
        B = b;
    }

    //Properties
    public double B { get => _b; set => _b = ValidateB(value); }

    //Methods
    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateB(double b)
    {
        if (b == 0)
        {
            throw new Exception($"The b: {b}, not is valid.");
        }
        return b;
    }
}
