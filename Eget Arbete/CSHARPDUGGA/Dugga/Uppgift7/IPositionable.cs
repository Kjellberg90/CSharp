using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dugga.Uppgift7
{
    interface IPositionable
    {
        public int x { get; }
        public int y { get; }

        public string Mymethod(int myInt, bool myBool)
        {
            return  "This is my return string";
        }
    }
}
