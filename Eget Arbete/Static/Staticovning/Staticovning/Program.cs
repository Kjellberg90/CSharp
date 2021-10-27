using System;
using Staticovning;

int[] array = { 4, 7 };
var sum = ArrayMath.Add(array);

Console.WriteLine( sum );

ArrayMath.IncreaseCounter();
ArrayMath.IncreaseCounter();
ArrayMath.IncreaseCounter();
ArrayMath.IncreaseCounter();
ArrayMath.IncreaseCounter();


Console.WriteLine(ArrayMath.HalfCounter);