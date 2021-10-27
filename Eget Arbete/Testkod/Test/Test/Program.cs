using System;


namespace Demo
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int pos;
            int[] arr = new int[5] { 35, 50, 55, 77, 98 };

            Console.WriteLine("Elements before deletion:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Element[" + (i) + "]: " + arr[i]);
            }

            // Let's say the position to delete the item is 2 i.e. arr[1]
            pos = Convert.ToInt32(Console.ReadLine()) + 1;
            // Shifting elements
            for (i = pos - 1; i < 4; i++)
            {
                arr[i] = arr[i + 1];
            }
            Console.WriteLine("Elements after deletion: ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }
         
        }
    }
}