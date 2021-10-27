using System;

//Challange The Triangle Farmer
/*
Console.WriteLine("What is the width of the triangle?");
double width = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is the height of the triangle?");
double height = Convert.ToDouble(Console.ReadLine());

double area = width * height / 2;
Console.WriteLine("The Area of the triangle is " + area);
*/

//Challange The Four Sisters abd the Duckbear

Console.WriteLine("How many eggs did you collect today");
int eggsCollected = Convert.ToInt32(Console.ReadLine());
int eggsForSisters = eggsCollected / 4;
Console.WriteLine("Each sister gets " + eggsForSisters + " eggs.");
int eggsForBear = eggsCollected % 4;
Console.WriteLine("The Duckbear gets " + eggsForBear + " eggs");


//Challange The Dominion of Kings

Console.WriteLine("How many provinces do you have");
int prov = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchies do you have");
int duch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many estates do you have");
int estate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("You hold " + prov + " provinces. " + duch + " duchies. " + estate + " estates.");
Console.WriteLine("Your total score is: " + (prov * 6 + duch * 4 + estate));

