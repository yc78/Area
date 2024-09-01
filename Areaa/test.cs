using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

class Test
{
    public void ProcessCoordinates(List<Tuple<double, double>> coordinates)
    {
        foreach (var coordinate in coordinates)
        {
            Console.WriteLine($"X: {coordinate.Item1}, Y: {coordinate.Item2}");
        }
    }
}


