using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticovning
{
    static class ArrayMath
    {
        private static int _counter = 0;

        public static double HalfCounter { 
            get 
            {
                return _counter / 2.0;
            } 
        }

        public static int Add(int[] numbers)
        {
            int sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            
            return sum;
        }

        public static void IncreaseCounter()
        {
            _counter++;
        }
    }
}
