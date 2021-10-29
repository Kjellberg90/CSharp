using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    class Rope : InventoryItem
    {
        public Rope() : base(1, 1.5)
        {

        }

        public override string ToString()
        {
            return "Rope";
        }
    }
}
