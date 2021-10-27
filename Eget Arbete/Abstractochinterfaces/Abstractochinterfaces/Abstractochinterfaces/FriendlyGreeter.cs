using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractochinterfaces 
{
    class FriendlyGreeter : Greeter
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello, how are you?");
        }
    }
}
