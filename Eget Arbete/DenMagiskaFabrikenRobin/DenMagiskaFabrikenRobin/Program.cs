using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabrikenRobin
{
    class Program
    {
        static void Main(string[] args)
        {

            Warehouse warehouseVar = new Warehouse();

            warehouseVar.AddToList(new Metal());
            warehouseVar.AddToList(new Metal());
            warehouseVar.AddToList(new Metal());
            warehouseVar.AddToList(new Rubber());
            warehouseVar.AddToList(new Rubber());
            warehouseVar.AddToList(new Rubber());
            warehouseVar.AddToList(new Metal());


            while (true)
            {
                Console.WriteLine("Material som ska med till fabriken:");
                warehouseVar.ListUserItems();
                Console.WriteLine();
                warehouseVar.ListWarehouseItems();
                Console.WriteLine();
                Console.WriteLine("Välj vad du ska ha med dig till fabriken");
                Console.WriteLine("När du är klar: skriv Send");

                var userInput = (Console.ReadLine());
                if (userInput == "Send")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    var convert1 = Convert.ToInt32(userInput);
                    warehouseVar.userChoice.Add(warehouseVar.materialList[convert1 - 1]);
                    warehouseVar.materialList.Remove(warehouseVar.materialList[convert1 - 1]);
                }
                Console.Clear();
            }

            Console.WriteLine("Material skickat till fabriken");
            warehouseVar.ListUserItems();

            Factory factoryVar = new Factory();
            while (true)
            {
                factoryVar.Listcomparison(warehouseVar.userChoice);
            }
        }
    }
}
