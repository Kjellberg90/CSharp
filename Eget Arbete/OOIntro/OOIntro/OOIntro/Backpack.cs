using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    class Backpack
    {
        public string[] Snacks { get; set; } = { "Cookies", "Sandwich", "Cake" };
        public string BackpackBrand { get; set; } 


        public Backpack() 
        {
            BackpackBrand = "Fjällräven";
        }

        public Backpack(string brand)
        {
            BackpackBrand = brand;
        }

    }

}
