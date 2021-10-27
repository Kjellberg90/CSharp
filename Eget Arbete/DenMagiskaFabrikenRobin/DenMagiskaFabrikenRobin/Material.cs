using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabrikenRobin
{
    abstract class Material
    {
        public Material() : base ()
        {
           
        }

        public MaterialChoice MaterialType { get; set; }


    }
}
