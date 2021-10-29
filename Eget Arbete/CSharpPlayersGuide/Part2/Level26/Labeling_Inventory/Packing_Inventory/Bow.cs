using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    class Bow : InventoryItem
    {
        public Bow() : base(1, 4)
        {

        }

        public override string ToString()
        {
            return "Bow";
        }
    }
}
