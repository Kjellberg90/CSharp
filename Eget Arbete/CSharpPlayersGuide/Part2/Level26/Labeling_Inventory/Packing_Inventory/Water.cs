using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    internal class Water : InventoryItem
    {
        public Water() : base(2, 3)
        {

        }

        public override string ToString()
        {
            return "Water";
        }
    }
}
