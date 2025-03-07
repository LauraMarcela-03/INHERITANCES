using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller02;

public class Rectangle : Square
{
    //Fields
    private double _b;

    //Constructor
    public Rectangle(string name, double a, double b) : base(name, a)
    {
        Name = name;
        B = b;
    }

    //Properties
    public double B { get => _b; set => _b = ValidateB(value); }

    //Methods
    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateB(double b)
    {
        if (b < 0)
        {
            throw new Exception($"The b: {b}, not is valid.");
        }
        return b;
    }
}
