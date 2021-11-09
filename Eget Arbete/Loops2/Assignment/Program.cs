using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[100];

            for (int i = 0; i < myIntArray.Length; i++)
            {
                int x = i + 1;
                if (x % 3 == 0)
                {
                    myIntArray[i] = x * myIntArray[i - 1];
                    
                }
                else if (x % 5 == 0)
                {
                    myIntArray[i] = (x + 15);
                }
                else
                {
                    myIntArray[i] = x;
                }
                Console.WriteLine($"ArrayPositionmy: {i} {myIntArray[i]}");
            }
        }
    }
}
