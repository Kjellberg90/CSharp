using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class MyBaseClass
    {
        protected int _myInt;
        private double _myDouble;
        
        public MyBaseClass(double myDouble)
        {
            _myDouble = myDouble;
        }
        
        public void baseAdd()
        {
            Console.WriteLine(_myInt + _myDouble);
        }
    }
}