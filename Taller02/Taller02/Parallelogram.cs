using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller02;

public class Parallelogram : Rectangle
{
    //Fields
    private double _h;

    //Constructor
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        Name = name;
        H = h;
    }

    //Properties
    public double H { get => _h; set => _h = ValidateH(value); }

    //Methods
    public override double GetArea()
    {
        return B * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new Exception($"The h: {h}, not is valid.");
        }
        return h;
    }
}
