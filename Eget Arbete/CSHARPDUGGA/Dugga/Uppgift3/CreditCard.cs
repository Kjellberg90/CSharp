using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dugga;

namespace Dugga.Uppgift3
{
    class CreditCard
    {
        private string _benefitLevel;
        private int _creditLimit;

        public CreditCard(string benefitLevel)
        {
            _benefitLevel = benefitLevel;
            _creditLimit = 10000;
        }

        public CreditCard() : this("bronze")
        {
        }

        public void ChangeLimit(int change)
        {
            _creditLimit = change;

            if (change <= 10000)
            {
                _benefitLevel = "bronze";
            }
            else if (change  > 10000 && change <= 50000)
            {
                _benefitLevel = "silver";
            }
            else
            {
                _benefitLevel = "gold";
            }
        }
    }
}

//3D.Byt typ på _benefitLevel så att den använder enum: en du skapade i 3C.
//Byt både i deklarationen och där variabeln används. (1p)