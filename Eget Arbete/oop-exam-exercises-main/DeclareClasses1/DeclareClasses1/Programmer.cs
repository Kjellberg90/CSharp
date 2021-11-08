using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareClasses1
{
    class Programmer
    {
        private bool _isHappy;

        public string Name{ get; init; }
        public int Age { get; private set; }

        public Programmer()
        {
            _isHappy = false;
        }

        public int ProduceCode()
        {
            if (_isHappy == true)
            {
                return 100;
            }
            else
            {
                return 50;
            }
        }

        public void DrinkCoffe()
        {
            _isHappy = true;
        }

        public void CelebrateBirthDay()
        {
            Age += 1;
            _isHappy = true;
        }
    }
}
