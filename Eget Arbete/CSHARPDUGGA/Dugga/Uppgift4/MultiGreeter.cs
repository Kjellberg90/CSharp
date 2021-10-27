using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dugga.Uppgift4
{
    class MultiGreeter
    {
        public void SayHello(string mesage, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(mesage);
            }
        }
    }
}
