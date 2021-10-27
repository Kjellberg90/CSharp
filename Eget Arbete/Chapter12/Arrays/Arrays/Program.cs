using System;

//Challange The replicator of D'To
int[] myArray = new int[5];

Console.WriteLine("Enter 5 numbers that will go into an array");

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The numbers in the original array is " + "[{0}]", string.Join(", ", myArray));

int[] newArray = new int[5];

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = myArray[i];
}

Console.WriteLine("The numbers in the copied array is " + "[{0}]", string.Join(", ", newArray));


//Challange The Laws of Freach

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int minValue = Int32.MaxValue;
int total = 0;
int summa = 0;


for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minValue)
    {
        minValue = array[i];
    }
}

Console.WriteLine("The lowest value in the array with a for loop is " + minValue);

foreach (int i in array)
{
    if (i < minValue)
    {
        minValue = array[i];
    }
}

Console.WriteLine("The lowest value in tha array with a foreach loop is " + minValue);

for (int i = 0; i < array.Length; i++)
{
    total += array[i];
}

float average = (float)total / array.Length;
Console.WriteLine("The average value of the array according to a for loop is: " + average);

foreach (int i in array)
{
    summa += i;
}

float average2 = (float)summa / array.Length;
Console.WriteLine("The average value of the array according to a foreach loop is: " + average2);