using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    class InventoryItem
    {
        public double Weight { get; set; }
        public double Volume { get; set; }
        

        public InventoryItem(double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }

    }
}
