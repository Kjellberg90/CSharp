using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractochinterfaces
{
    class Chair : IImovable
    {
        public void Move(int x, int y)
        {
            Console.WriteLine($"Stolen flyttas till {x}, {y}");
        }
    }
}
