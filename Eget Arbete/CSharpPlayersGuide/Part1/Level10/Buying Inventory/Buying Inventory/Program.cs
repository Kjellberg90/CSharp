int item1 = 10;
int item2 = 15;
int item3 = 25;
int item4 = 1;
int item5 = 20;
int item6 = 200;
int item7 = 1;


Console.WriteLine("Hello, Traveler");
Console.WriteLine("The Following items are available");
Console.WriteLine("---------------------------------");
Console.WriteLine("1: Rope");
Console.WriteLine("2: Torches");
Console.WriteLine("3: Climbing Equipment");
Console.WriteLine("4: Clean water");
Console.WriteLine("5: Machete");
Console.WriteLine("6: Canoe");
Console.WriteLine("7: Food Supplies");
Console.WriteLine("---------------------------------");
Console.WriteLine("What number do you want to see the price of?");

int userChoise = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("By the way what is your name?");
string userName = Console.ReadLine();
if (userName == "Daniel")
{
    item1 = item1 / 2; ;
    item2 = item2 / 2; ;
    item3 = item3 / 2; ;
    item4 = item4 / 2; ;
    item5 = item5 / 2; ;
    item6 = item6 / 2; ;
    item7 = item7 / 2; ;
}

switch (userChoise)
{
    case 1:
        Console.WriteLine($"The Cost of rope is {item1} Gold");
        break;
    case 2:
        Console.WriteLine($"The Cost of torches is {item2} Gold");
        break;
    case 3:
        Console.WriteLine($"The Cost of Climbing Equipment is {item3} Gold");
        break;
    case 4:
        Console.WriteLine($"The Cost of Clean water is {item4} Gold");
        break;
    case 5:
        Console.WriteLine($"The Cost of Machete is {item5} Gold");
        break;
    case 6:
        Console.WriteLine($"The Cost of Canoe is {item6} Gold");
        break;
    case 7:
        Console.WriteLine($"The Cost of Food Supplies is {item7}Gold");
        break;
    default:
        Console.WriteLine("We dont have that item in our inventory");
        break;
}