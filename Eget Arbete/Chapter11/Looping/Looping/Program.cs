using System;

//Challange The Prototype
Console.WriteLine("User 1, enter a number from 1 and 100:");
int target = 0;

while (true)
{
    target = Convert.ToInt32(Console.ReadLine());
    if (target > 0 && target <= 100)
    {
        Console.Clear();
        break;
    }
    else if (target <= 0 || target > 100)
    {
        Console.WriteLine("User 1, enter a number between 0 and 100:");
    }
}

Console.WriteLine("User 2, Guess the target number");
int guess = 0;

while (guess != target)
{
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess < target)
    {
        Console.WriteLine("Guess a higher number");
    }
    else if (guess > target)
    {
        Console.WriteLine("Guess a lower number");
    }
    else if (guess == target)
    {
        Console.WriteLine("You guessed the right number");
        break;
    }
}



//Challange The Magic Cannon


for (int i = 1; i <=100; i++)
{
    if (i % 3 == 0 && i % 5 ==0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(i + ": Super MEGA Fire/Electric");
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(i + ": Fire");
    } 
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(i + ": Electric");
    } 
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(i + ": Normal");
    }
}
