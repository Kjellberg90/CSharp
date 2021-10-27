using System;
using Enumerations;

Chest status = Chest.Open;


while (true)
{
    switch (status)
    {
        case Chest.Open:
            Console.WriteLine("The Chest is Opened, to close it write close.");
            string input = Console.ReadLine();

            if (input == "close")
            {
                status = Chest.Closed;
            }
            break;
        case Chest.Closed:
            Console.WriteLine("The Chest is Closed, do you want to open or lock the chest?.");
            string input2 = Console.ReadLine();

            if (input2 == "open")
            {
                status = Chest.Open;
            }
            if (input2 == "lock")
            {
                status = Chest.Locked;
            }
            break;
        case Chest.Locked:
            Console.WriteLine("The Chest is Locked,to unlock the chest write unlock?.");
            string input3 = Console.ReadLine();
            
            if (input3 == "unlock")
            {
                status = Chest.Open;
            }
            break;
        default:
            Console.WriteLine("Wrong type of command");
            break;
    }
}
