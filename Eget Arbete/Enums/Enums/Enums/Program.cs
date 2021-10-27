using System;
using Enums;

OrderStatus myPizzaorder = OrderStatus.Ordered;


while (myPizzaorder != OrderStatus.Delivered)
{
    switch (myPizzaorder)
    {
        case OrderStatus.Ordered:
            Console.WriteLine("Är Pizzan klar? y");
            string status = Console.ReadLine();
            if (status == "y")
            {
                myPizzaorder = OrderStatus.Ready;
            }
            Console.WriteLine(myPizzaorder);
            break;
        case OrderStatus.Ready:
            Console.WriteLine("Är pizzan leverad? y");
            string status2 = Console.ReadLine();
            if (status2 == "y")
            {
                myPizzaorder = OrderStatus.Delivered;
            }
            break;
        case OrderStatus.Delivered:
            Console.WriteLine(myPizzaorder);
            break;
        default:
            Console.WriteLine("Ej klar");
            break;
    }
}