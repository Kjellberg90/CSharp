Console.WriteLine("Enter a x value");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a y value");
int y = Convert.ToInt32(Console.ReadLine());

if( x < 0 && y > 0)
{
    Console.WriteLine("The enimie is coming from NW");
} 
else if (x == 0 && y > 0)
{
    Console.WriteLine("The enimie is coming from N");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("The enimie is coming from NE");
}
else if (x < 0 && y == 0)
{
    Console.WriteLine("The enimie is coming from W");
}
else if (x == 0 && y == 0)
{
    Console.WriteLine("The enimies is here already");
}
else if (x > 0 && y == 0)
{
    Console.WriteLine("The enimie is coming from E");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("The enimie is coming from SW");
}
else if (x == 0 && y < 0)
{
    Console.WriteLine("The enimie is coming from S");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("The enimie is coming from SE");
}