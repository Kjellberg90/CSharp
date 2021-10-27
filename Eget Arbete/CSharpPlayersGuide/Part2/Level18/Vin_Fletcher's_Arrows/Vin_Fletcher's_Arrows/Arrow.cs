using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vin_Fletcher_s_Arrows;

namespace Vin_Fletcher_s_Arrows
{
    class Arrow
    {
        public ArrowHead _arrowHead;
        public Fletchling _fletchling;
        public int _shaftLenght;

        public Arrow()
        {

        }

        public Arrow(ArrowHead arrowHead, Fletchling fletchling, int shaftLenght)
        {
            _arrowHead = arrowHead;
            _fletchling = fletchling;
            _shaftLenght = shaftLenght;
        }

        public double GetCost(ArrowHead _arrowHead, Fletchling _fletchling, double _shaftLenght)
        {
            double sum = 0;
            if (_arrowHead == ArrowHead.steel)
            {
                sum += 10;
            }
            else if (_arrowHead == ArrowHead.wood)
            {
                sum += 3;
            }
            else if (_arrowHead == ArrowHead.obsidian)
            {
                sum += 5;
            }

            if (_fletchling == Fletchling.plastic)
            {
                sum += 10;
            }
            else if (_fletchling == Fletchling.turkeyFether)
            {
                sum += 5;
            }
            else if (_fletchling == Fletchling.gooseFether)
            {
                sum += 3;
            }

            sum += _shaftLenght * 0.05;

            return sum;
        }
    }
}
