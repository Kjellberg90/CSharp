using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vin_Fletcher_s_Arrows
{
    class Arrow
    {
        private ArrowHead _arrowHead;
        private Fletchling _fletchling;
        private int _shaftLenght;

        public ArrowHead GetArrowHead() => _arrowHead;
        public Fletchling GetFletchling() => _fletchling;
        public int GetShaftLenght() => _shaftLenght;

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
