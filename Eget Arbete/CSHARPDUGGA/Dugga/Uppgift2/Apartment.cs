using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dugga.Uppgift2
{
    class Apartment
    {
        private int _floor;

        public int Floor
        {
            get
            {
                return _floor;
            }
        }
        public int Number { get; }
        public Apartment()
        {
            _floor = 0;
        }
    }
}


