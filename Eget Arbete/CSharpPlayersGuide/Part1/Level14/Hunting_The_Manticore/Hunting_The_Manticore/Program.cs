using System;
//----------------------------------
Random random = new Random();
int manticorePosition = random.Next(0, 101);
Console.WriteLine(manticorePosition);
//----------------------------------


Console.WriteLine("--------------------------------------------------------");
Console.WriteLine($"STATUS: Round 0 City: 15/15 Manticore 10/10");
Console.WriteLine($"The cannon is expected to deal 1 damage this round");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Welcome Hero, how far away do you want to aim??? (0-100)");
bool gamestate = true;
int roundNumber = 0;
int cityHP = 15;
int cannonDamage;
string isHit;
int range;
int manticoreHealth = 10;


while (gamestate == true)
{
    //Roundnumber
    if (roundNumber == 16)
    {
        Console.WriteLine("You have run out of rounds and the manticore have destroyed the city");
        gamestate = false;
    }
    else
    {
        roundNumber += 1;
    }
    //City HP
    cityHP--;

    //Cannondamage
    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
    {
        cannonDamage = 10;
    }
    else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
    {
        cannonDamage = 3;
    }
    else 
    {
        cannonDamage = 1;
    }

    //Range of shot
    range = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    //Check if shot overshot or fell short
    if (range < manticorePosition)
    {
        isHit = "That round fell short of the target";
    } 
    else if (range > manticorePosition)
    {
        isHit = "That round overshot the target";
    }
    else
    {
        isHit = "The round hit the target";
    }
    //Manticore HP
    if (range == manticorePosition)
    {
        manticoreHealth = manticoreHealth - cannonDamage;
    }

    //End game
    if (manticoreHealth <= 0)
    {
        Console.WriteLine("The manticore is defeated");
        gamestate = false;
    }
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine($"STATUS: Round {roundNumber } City: {cityHP}/15 Manticore {manticoreHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round");
    Console.WriteLine($"The range of your last shot was: {range}");
    Console.WriteLine(isHit);
    Console.WriteLine("--------------------------------------------------------");
}