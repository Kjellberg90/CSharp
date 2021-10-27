using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faglar
{
    abstract class Bird
    {
        public string _Species { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine($"The { _Species } flies" );
        }
    }
}
