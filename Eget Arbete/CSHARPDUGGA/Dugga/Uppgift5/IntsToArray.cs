using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dugga.Uppgift5
{
    class IntsToArray
    {
        public static int[] ToArray(int x, int y, int z)
        {
            int[] myArray = new int[3] { x, y, z };
            return myArray;
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
