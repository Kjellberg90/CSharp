using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass() : base(12.3)
        {
            _myInt = 5;
        }

        public void DerivedMessage()
        {
            Console.WriteLine("Hej");
        }
    }    
}
