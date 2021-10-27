int[] myIntArray = new int[] { 66,34,66,56,7,43,6 };
double sum = 0;
int lowestItem = Int32.MaxValue;

foreach (int item in myIntArray)
{
    sum = sum + item;
}

foreach (int item in myIntArray)
{
    if (item < lowestItem)
    {
        lowestItem = item;
    }
}

Console.WriteLine($"The total sum of the array is {sum}");
Console.WriteLine($"The average value is {sum / myIntArray.Length}");
Console.WriteLine($"The lowest value is {lowestItem}");


