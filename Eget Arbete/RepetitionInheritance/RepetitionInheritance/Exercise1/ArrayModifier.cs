using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance.Exercise1
{
    abstract class ArrayModifier
    {
        private int[] _array;

        public ArrayModifier(int[] array)
        {
            _array = array;
        }

        protected abstract int ModifyValue(int myInt);

        public void Modify()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = ModifyValue(_array[i]);
                Console.WriteLine(_array[i]);
            }
        }
    }
}
