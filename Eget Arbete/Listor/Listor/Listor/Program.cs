using System;
using System.Collections.Generic;

List<int> myList = new List<int>() {1, 2, 3, 4, 5 };

Console.WriteLine(myList[2]);

myList.RemoveAt(0);

myList.AddRange(new int[] { 10, 20, 30 });

Console.WriteLine(myList.Count);

for (int i = 0; i < myList.Count - 1; i++)
{
    if (myList[i] % 2 == 0)
    {
        Console.WriteLine("Hej");
    }
}
