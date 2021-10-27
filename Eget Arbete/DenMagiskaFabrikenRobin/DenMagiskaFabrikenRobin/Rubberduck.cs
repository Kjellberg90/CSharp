using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabrikenRobin
{
    class Rubberduck : Product
    {
        public List<Material> ritningDuck = new List<Material>() { new Rubber(), new Rubber()};

        public Rubberduck() { ritning = ritningDuck; }

    }
}
