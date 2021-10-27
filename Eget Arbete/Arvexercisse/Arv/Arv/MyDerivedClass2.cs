using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class MyDerivedClass2 : MyBaseClass
    {
        public MyDerivedClass2(double _myDouble) : base(_myDouble)
        {
            _myInt = 8;
        }
    }
}
