using System;

string[] hangmanWord = new string[] { "B", "a", "n", "a", "n" };
bool[] checkWord = new bool[] { false, false, false, false, false };
string usedLetters = "";
string input = "";
string lives = "|";
string nolife = "";
int maxLives = 5;
int dead = 0;



while (true)
{
    if (maxLives == 5)
    {
        lives = "|||||";
    }
    else if (maxLives == 4)
    {
        lives = "||||";
    }
    else if (maxLives == 3)
    {
        lives = "|||";
    }
    else if (maxLives == 2)
    {
        lives = "||";
    }
    else if (maxLives == 1)
    {
        lives = "|";
    }

    var completed = true;
    for (var i = 0; i < checkWord.Length; i++)
    {
        if (!checkWord[i])
        {
            completed = false;
            break;
        }
    }

    if (completed)
    {
        Console.WriteLine("Bra jobbat du har gissat ordet");
        break;
    }


    if (maxLives > dead)
    {
        Console.Write($"Antal försök kvar: {lives}");
    }
    else if (maxLives == dead)
    {
        Console.WriteLine("Du har förlorat spelet");
        break;
    }



    Console.WriteLine();
    for (int i = 0; i < checkWord.Length; i++)
    {
        if (checkWord[i] == false)
        {
            Console.Write("_");
        }
        else if (checkWord[i] == true)
        {
            Console.Write(hangmanWord[i]);
        }
    }

    Console.WriteLine();
    Console.WriteLine("Gissade bokstäver:");

    if (usedLetters == "")
    {
        usedLetters = input;
    }
    else
    {
        usedLetters = usedLetters + ", " + input;
    }

    Console.WriteLine(usedLetters);

    Console.WriteLine("Skriv en bokstav ny för att göra en gissning!");
    input = Console.ReadLine().ToLower();
    Console.WriteLine();

    for (int i = 0; i < hangmanWord.Length; i++)
    {
        if (input == hangmanWord[i].ToLower())
        {
            checkWord[i] = true;
        }
        else if (input == "")
        {
            continue;
        }
    }

    var match = false;
    for (int i = 0; i < hangmanWord.Length; i++)
    {
        if (input.ToLower() == hangmanWord[i].ToLower())
            match = true;
    }

    if (!match)
    {
        maxLives -= 1;
    }
    Console.Clear();
}