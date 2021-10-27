using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabrikenRobin
{
    class Warehouse : IAddToList
    {

        public List<Material> userChoice = new List<Material>();
        public List<Material> materialList = new List<Material>();
        public Warehouse ()
        {
            
        }
        public void AddToList(Material material)
        {
            materialList.Add(material);
        }

        public void ListWarehouseItems()
        {
            Console.WriteLine("Detta finns i lagret:");

            for (int i = 0; i < materialList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {materialList[i]}");
            }
        }
        public void ListUserItems()
        {
            for (int i = 0; i < userChoice.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {userChoice[i]}");
            }
        }
    }
}
