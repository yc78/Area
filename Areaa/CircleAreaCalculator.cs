using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CircleAreaCalculator : IAreaCalculator
{
    public double CalculateArea(List<Tuple<double, double>> points)
    {
        double radius = points[0].Item1;
        return Math.PI * radius * radius;
    }
}
