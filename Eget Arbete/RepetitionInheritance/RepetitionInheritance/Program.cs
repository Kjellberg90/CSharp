using System;
using RepetitionInheritance.Exercise1;
using System.Collections.Generic;

int[] myIntArray = new int[5] { 1, 8, 3, 4, 5 };
for (int i = 0; i < myIntArray.Length; i++)
{
    Console.WriteLine(myIntArray[i]);
}

Console.WriteLine("--------------------------------");
ArrayModifier modify = new IncrementModifier(myIntArray);

modify.Modify();