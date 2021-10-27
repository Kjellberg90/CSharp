using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faglar
{
    class Ostrich : Bird 
    {
        public Ostrich()
        {
            _Species = "Ostrich";
        }

        public override void Fly()
        {
            Console.WriteLine($"The { _Species } does not fly");
        }
    }
}
