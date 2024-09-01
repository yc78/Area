using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PolygonAreaCalculator : IAreaCalculator
{
    public double CalculateArea(List<Tuple<double, double>> points)
    {
        double area = 0;
        int j = points.Count - 1;

        for (int i = 0; i < points.Count; i++)
        {
            area += (points[j].Item1 + points[i].Item1) * (points[j].Item2 - points[i].Item2);
            j = i;
        }

        return Math.Abs(area / 2);
    }
}
