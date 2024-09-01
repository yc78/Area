using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IAreaCalculator
{
    double CalculateArea(List<Tuple<double, double>> points);
}