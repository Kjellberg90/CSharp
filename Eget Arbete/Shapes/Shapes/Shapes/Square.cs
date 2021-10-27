using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : IShape
    {
        public int _side { get; }

        public Square(int Side)
        {
            _side = Side;
        }


        public double GetArea()
        {
            return _side * _side;
        }
    }
}

