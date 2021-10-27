using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Exercise1
{
    internal class IncrementModifier : ArrayModifier
    {
        public IncrementModifier(int[] array) : base(array) 
        {
            
        }

        protected override int ModifyValue(int myInt)
        {
            return myInt + 1;
        }
    }
}

