using System;

//Challenge The Thing Namer 3000

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); //Stores Item
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); //Describe the item with one word
string c = " of Dooom"; //Stores text
string d = " 3000"; //Stores text
Console.WriteLine("The " + b + " " + a + c + d + "!");