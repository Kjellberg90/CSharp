using System;
/*
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;

string myString = "I am the greatest.";

Console.WriteLine($"Who is the greatest? {myString}.");
*/

//Challange The Defense of Consolas

Console.Title = "Defense of Consolas";

Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Target Column? ");
int targetCol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Deploy troops to:");

Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine("(" + targetRow + ", " + (targetCol - 1) + ")");
Console.WriteLine("(" + (targetRow - 1) + ", " + targetCol + ")");
Console.WriteLine("(" + targetRow + ", " + (targetCol + 1) + ")");
Console.WriteLine("(" + (targetRow + 1) + ", " + targetCol + ")");

Console.WriteLine("----------------------");

Console.WriteLine($"({targetRow}, {targetCol - 1})");
Console.WriteLine($"({targetRow - 1}, {targetCol})");
Console.WriteLine($"({targetRow}, {targetCol + 1})");
Console.WriteLine($"({targetRow + 1}, {targetCol})");

Console.Beep();
