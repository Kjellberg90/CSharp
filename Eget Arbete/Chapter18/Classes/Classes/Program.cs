using System;
using Classes;

Console.WriteLine("Do you want steel, wood, or obsidian for the head?");
var headChoice = Console.ReadLine();
Arrow head = new Arrow();
var summa = head.GetCostMaterial(headChoice);

Console.WriteLine("Do you want plastic, turkey, or goose for the fletching?");
var fletchingChoice = Console.ReadLine();
Arrow fletching = new Arrow();
var summa2 = fletching.GetCostMaterial(fletchingChoice);

Console.WriteLine("Enter the lenght of the arrow in CM");
var arrowLenght = Convert.ToDouble(Console.ReadLine());
Arrow lenght = new Arrow();
var summa3 = lenght.GetCostLenght(arrowLenght);

Console.WriteLine(summa + summa2 + summa3);