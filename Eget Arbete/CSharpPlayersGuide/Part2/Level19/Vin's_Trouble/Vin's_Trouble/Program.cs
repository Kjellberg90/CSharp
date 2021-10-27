using Vin_Fletcher_s_Arrows;

ArrowHead x = getArrowHeadType();
Fletchling y = getFletchlingType();
int z = ShaftLenght();

Arrow arrow = new Arrow();
var cost = arrow.GetCost(x, y, z);
Console.WriteLine(cost);


ArrowHead getArrowHeadType()
{
    Console.WriteLine("What kind of arrowhead do you want? Steel, Wood or obsidian?");
    string input = Console.ReadLine();
    switch (input)
    {
        case "Steel":
            Console.WriteLine("You have choosen Steel arrowhead");
            return ArrowHead.steel;
        case "Wood":
            Console.WriteLine("You have choosen Wood arrowhead");
            return ArrowHead.wood;
        case "Obsidian":
            Console.WriteLine("You have choosen Obsidian arrowhead");
            return ArrowHead.obsidian;
        default:
            Console.WriteLine("Going for standard steel arrowhead");
            return ArrowHead.steel;
    }
}

Fletchling getFletchlingType()
{
    Console.WriteLine("What kind of fletchling do you want? Plastic, Turkey or Goose?");
    string input = Console.ReadLine();
    switch (input)
    {
        case "Plastic":
            Console.WriteLine("You have choosen Plastic fletchling");
            return Fletchling.plastic;
        case "Turkey":
            Console.WriteLine("You have choosen Turkey fletchling");
            return Fletchling.turkeyFether;
        case "Goose":
            Console.WriteLine("You have choosen Goose fletchling");
            return Fletchling.gooseFether;
        default:
            Console.WriteLine("Going for standard Plastic fletchling");
            return Fletchling.plastic;
    }
}

int ShaftLenght()
{
    Console.WriteLine("How long do you want your shaft to be?");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}