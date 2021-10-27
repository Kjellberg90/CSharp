using Simula_s_Test;


var chestStatus = ChestStatus.Closed;
while (true)
{
    switch (chestStatus)
    {
        case ChestStatus.Opened:
            Console.WriteLine("The Chest is currently opened. Write close to close the chest");
            string input = Console.ReadLine();
            if (input == "close")
            {
                chestStatus = ChestStatus.Closed;
            }
            break;
        case ChestStatus.Closed:
            Console.WriteLine("The Chest is currently closed. Do you want to open or lock the chest?");
            string input2 = Console.ReadLine();
            if (input2 == "open")
            {
                chestStatus = ChestStatus.Opened;
            }
            else if (input2 == "lock")
            {
                chestStatus = ChestStatus.Locked;
            }
            break;
        case ChestStatus.Locked:
            Console.WriteLine("The Chest is currently locked. Write unlock to unlock the chest");
            string input3 = Console.ReadLine();
            if (input3 == "unlock")
            {
                chestStatus = ChestStatus.Closed;
            }
            break;
        default:
            break;
    }
}
