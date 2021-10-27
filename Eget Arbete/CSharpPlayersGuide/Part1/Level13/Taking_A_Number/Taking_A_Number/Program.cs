
Console.WriteLine("Enter a number from 1 to 100");
string input = Console.ReadLine();
AskForSomething(input);


void AskForSomething(string text)
{
    AskForNumber(text, 0, 100);
}

int AskForNumber(string text, int min, int max)
{
    int num = Convert.ToInt32(text);
    if (num > max)
    {
        Console.WriteLine("Enter a number from 1 to 100");
        string input = Console.ReadLine();
        AskForSomething(input);
        return num;
    }
    else if (num < min)
    {
        Console.WriteLine("Enter a number from 1 to 100");
        string input = Console.ReadLine();
        AskForSomething(input);
        return num;
    } 
    else
    {
        Console.WriteLine("Good job you entered a valid number");
        return num;
    }
}