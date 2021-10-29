using Packing_Inventory;

Pack pack = new Pack(10, 20, 30);

while (true)
{
    Console.WriteLine($"Yor Backpack is currently at Weight: {pack.CurrentWeight}/{pack.MaxWeight} Volume: {pack.CurrentVolume}/{pack.MaxVolume} Items: {pack.CurrentItem}/{pack.MaxNumberOfItems}");
    Console.WriteLine($"Your bag currently contains:{pack}");

    Console.WriteLine("What do you want to add to your backpack?");
    Console.WriteLine("1. Arrow");
    Console.WriteLine("2. Bow");
    Console.WriteLine("3. Rope");
    Console.WriteLine("4. Water");
    Console.WriteLine("5. Food");
    Console.WriteLine("6. Sword");

    int input = Convert.ToInt32(Console.ReadLine());

    InventoryItem newitem = input switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword()
    };

    if (!pack.Add(newitem))
    {
        Console.WriteLine("Cold not add to pack");
    }
}


