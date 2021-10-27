using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : IShape
    {
        public double pi { get; set; } = Math.PI;
        public double _radius { get; set; }

        public Circle(double Radius)
        {
            _radius = Radius;
        }

        public double GetArea()
        {
            return pi * Math.Pow(_radius, 2);
        }
    }


}
