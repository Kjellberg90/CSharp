using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurpark
{
    class Animal
    {
        private int _numberOfLegs;

        public int NumberOfLegs
        {
            get
            {
                return _numberOfLegs;
            }
        }
        protected Animal(string animal)
        {

        }

        public static void Feed(string food)
        {
            Console.WriteLine($"The animal is eating {food}");
        }
    }
}
