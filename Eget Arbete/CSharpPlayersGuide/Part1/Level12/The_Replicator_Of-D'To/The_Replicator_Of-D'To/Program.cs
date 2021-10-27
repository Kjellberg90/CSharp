int[] myIntArray = new int[5];

for (int i = 0; i < myIntArray.Length; i++)
{
    Console.WriteLine($"Enter the array item: {i + 1}");
    myIntArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("--------------------------------------");
Console.WriteLine("This is what my input array looks like");
for (int i = 0; i < myIntArray.Length; i++)
{
    Console.WriteLine(myIntArray[i]);
}
int[] mynewArray = new int[5];

for (int i = 0; i < mynewArray.Length; i++)
{
    mynewArray[i] = myIntArray[i];
}

Console.WriteLine("--------------------------------------");
Console.WriteLine("This is what my copied array looks like");
for (int i = 0; i < mynewArray.Length; i++)
{
    Console.WriteLine(mynewArray[i]);
}