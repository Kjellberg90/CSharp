using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Arrow
    {
        public double _sum = 0;

        public Arrow()
        {
 
        }
        public double GetCostMaterial(string cost)
        {
            if (cost == "wood")
            {
                _sum += 3;
            }
            else if (cost == "steel")
            {
                _sum += 10;
            }
            else if (cost == "obsidian")
            {
                _sum += 5;
            }
            else if (cost == "plastic")
            {
                _sum += 10;
            }
            else if (cost == "turkey")
            {
                _sum += 5;
            }
            else if (cost == "goose")
            {
                _sum += 3;
            }
            return _sum;
        }

        public double GetCostLenght(double lenght)
        {
            _sum = lenght * 0.05;
            return _sum;
        }
    }
}
