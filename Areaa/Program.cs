using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Tuple<double, double>> points = new List<Tuple<double, double>>
        {
            Tuple.Create(0.0, 0.0),
            Tuple.Create(4.0, 0.0),
            Tuple.Create(4.0, 3.0),
            Tuple.Create(2.0, 5.0),
            Tuple.Create(0.0, 3.0)
        };

        IAreaCalculator calculator = new PolygonAreaCalculator();
        Console.WriteLine(calculator.CalculateArea(points));
    }
}
