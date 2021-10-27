using System;

void CountToTen()
{
    for (int index = 1; index <= 10; index++)
        Console.WriteLine(index);
}

CountToTen();

////Challange Taking a number

int number = AskForNumberInRange(1000000, 1 , 100);

int AskForNumberInRange(int text, int min, int max) {
    Console.WriteLine(text + "sldaygfb");
    Convert.ToInt32(text);
    
    
    return text;
}
























/*

int number = AskForNumberInRange("User 1, enter a number between 0 and 100:", 0, 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (true)
{
    int guess = AskForNumber("What is your next guess?");
    if (guess > number) Console.WriteLine($"{guess} is too high.");
    else if (guess < number) Console.WriteLine($"{guess} is too low.");
    else break;
}

Console.WriteLine("You guessed the number!");


int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;
    }
}

*/