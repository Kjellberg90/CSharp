using System;

//Challange Repairing the Clocktower

/*
Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
    Console.WriteLine("Tick");
} else
{
    Console.WriteLine("Tock");
}
*/

//Challange Watchtower

Console.WriteLine("Enter a value for X");
int xValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a value for Y");
int yValue = Convert.ToInt32(Console.ReadLine());

if (xValue < 0 && yValue > 0)
    {
    Console.WriteLine("The enemy is approaching from NW");
    }
    else if (xValue == 0 && yValue > 0)
    {
         Console.WriteLine("The enemy is approaching from N");
    }
    else if (xValue > 0 && yValue > 0)
    {
        Console.WriteLine("The enemy is approaching from NE");
    }
    else if (xValue < 0 && yValue == 0)
    {
        Console.WriteLine("The enemy is approaching from W");
    }
    else if (xValue == 0 && yValue == 0)
    {
        Console.WriteLine("The enemy have infiltrated the fortress");
    }
    else if (xValue > 0 && yValue == 0)
    {
        Console.WriteLine("The enemy is approaching from E");
    } 
    else if (xValue < 0 && yValue < 0)
    {
        Console.WriteLine("The enemy is approaching from SW");
    }
    else if (xValue == 0 && yValue < 0 )
    {
        Console.WriteLine("The enemy is approaching from S");
    } else if (xValue > 0 && yValue < 0)
    {
        Console.WriteLine("The enemy is approaching from SE");
    } else
    {
    Console.WriteLine("The enemies position is unknown");
}