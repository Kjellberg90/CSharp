Console.WriteLine("Player 1 enter a number from 1 to 100");


int userInput1 = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (userInput1 < 1)
    {
        Console.WriteLine("Number to low enter a number from 1 to 100");
        userInput1 = Convert.ToInt32(Console.ReadLine());
    }
    else if (userInput1 > 100)
    {
        Console.WriteLine("Number to high enter a number from 1 to 100");
        userInput1 = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        userInput1 = userInput1;
        break;
    }
}

Console.Clear();
Console.WriteLine("Player 2 guess the number");

while (true)
{
    int userInput2 = Convert.ToInt32(Console.ReadLine());

    if (userInput2 == userInput1)
    {
        Console.WriteLine("You have won the game");
        break;
    }
    else if (userInput2 > userInput1)
    {
        Console.Clear();
        Console.WriteLine("Guess a lower number");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Guess a higher number");
    }
}