using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller02;

public abstract class GeometricFigure
{

    //Properties
    public string Name { get; set; } = null!;

    //Methods
    public override string ToString()
    {
        return $"{Name,-19} =>  Area.....: {GetArea(),12:F5}    Perimeter: {GetPerimeter(),12:F5}." ;
    }

    public abstract double GetArea();

    public abstract double GetPerimeter();

}
