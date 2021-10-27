recurse(10);


void recurse(int myInt)
{
    Console.WriteLine(myInt);
    if (myInt == 0)
    {
        Console.WriteLine("The bomb have exploded");
    }
    else
    {
        Thread.Sleep(1000);
        recurse(myInt - 1);
    }
}