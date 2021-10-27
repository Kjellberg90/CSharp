using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabrikenRobin
{
    class Rubber : Material
    {
        public Rubber()
        {
            MaterialType = MaterialChoice.Rubber;
        }
        public override string ToString()
        {
            return "Rubber";
        }
    }
}
