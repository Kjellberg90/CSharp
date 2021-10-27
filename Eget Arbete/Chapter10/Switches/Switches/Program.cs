using System;

//Challange Bying Inventory

Console.WriteLine("The following items are available:");
Console.WriteLine("---------------------------");
Console.WriteLine("1 – Rope");
Console.WriteLine("2 – Torches");
Console.WriteLine("3 – Climbing Equipment");
Console.WriteLine("4 – Clean Water");
Console.WriteLine("5 – Machete");
Console.WriteLine("6 – Canoe");
Console.WriteLine("7 – Food Supplies");
Console.WriteLine("---------------------------");

Console.WriteLine("What number do you want to see the price of (1-7)?");
int itemNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

string item = itemNumber switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equpment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies"
};

int price = item switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 3
};

if (name == "Daniel")
{
    price /= 2;
}

Console.WriteLine($"Welcome {name} the price of {item} is {price}G");
















/*
if (name == "Daniel")
{
    int price = item switch
    {
        "Rope" => 5,
        "Torches" => 8,
        "Climbing Equipment" => 13,
        "Clean Water" => 0,
        "Machete" => 10,
        "Canoe" => 100,
        "Food Supplies" => 0
    };
    Console.WriteLine($"The Cost of {item} is {price}");

} else {
    int price = item switch
    {
        "Rope" => 10,
        "Torches" => 15,
        "Climbing Equipment" => 25,
        "Clean Water" => 1,
        "Machete" => 20,
        "Canoe" => 200,
        "Food Supplies" => 1
    };
    Console.WriteLine($"The Cost of {item} is {price}");
}
*/














/*
switch (itemNumber)
{
    case 1:
        Console.WriteLine("The cost of Rope is 10G");
        break;
    case 2:
        Console.WriteLine("The cost of Torches is 50G");
        break;
    case 3:
        Console.WriteLine("The cost of Climbing Equipment is 60G");
        break;
    case 4:
        Console.WriteLine("The cost of Clean Water is 5G");
        break;
    case 5:
        Console.WriteLine("The cost of Machete is 25G");
        break;
    case 6:
        Console.WriteLine("The cost of Canoe is 100G");
        break;
    case 7:
        Console.WriteLine("The cost of Food Supplies is 45G");
        break;
}
*/