using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : IShape
    {
        public double _height { get; set; }
        public double _width { get; set; }

        public Triangle(double Height, double Width)
        {
            _height = Height;
            _width = Width;
        }

        public double GetArea()
        {
            return (_height * _width) / 2 ;
        }
    }
}
