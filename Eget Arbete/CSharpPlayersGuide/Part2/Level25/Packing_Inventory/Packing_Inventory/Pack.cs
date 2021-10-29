using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    internal class Pack
    {
        public double  MaxWeight{ get; }
        public double  MaxVolume{ get; }
        public int  MaxNumberOfItems{ get; }

        private InventoryItem[] _item;

        public double CurrentWeight { get; set; }
        public double CurrentVolume { get; set; }
        public int CurrentItem { get; set; }

        public int MyProperty { get; set; }
        public Pack(double maxWeight, double maxVolume,int maxNumberOfItems)
        {
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
            MaxNumberOfItems = maxNumberOfItems;

            _item = new InventoryItem[maxNumberOfItems];
        }

        public bool Add(InventoryItem item)
        {
            if (CurrentItem > MaxNumberOfItems)
            {
                return false;
            }
            if (CurrentVolume + item.Volume > MaxVolume)
            {
                return false;
            }
            if (CurrentWeight + item.Weight > MaxWeight)
            {
                return false;
            }

            _item[CurrentItem] = item;

            CurrentVolume = CurrentVolume + item.Volume;
            CurrentWeight = CurrentWeight + item.Weight;
            CurrentItem++;
            return true;
            
        }

    }
}
