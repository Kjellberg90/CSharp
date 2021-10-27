using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractochinterfaces
{
    class Book : IImovable
    {
        public void Move(int x, int y)
        {
            Console.WriteLine($"Boken flyttas till {x}, {y}");
        }
    }
}
