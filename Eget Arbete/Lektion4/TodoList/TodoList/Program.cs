using System;

string[] todo = new string[] { "Handla", "Träna", "Programera" };
bool[] status = new bool[] { true, false, false };

Console.WriteLine("1. Do you want to see the todo list");
Console.WriteLine("2. Do you want to add new todo");
Console.WriteLine("3. Do you want to update status on a todo");
Console.WriteLine("----------------------------------------------");

var userInput = Console.ReadKey();

//List befintliga todos
if (userInput == 1)
{
    Console.WriteLine($"{todo}");
}
//Lägg till ny todo

// Uppdatera status på befintlig todo





