using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vin_Fletcher_s_Arrows
{
    class Arrow
    {
        public ArrowHead ArrowHead { get; }
        public Fletchling Fletchling { get; }
        public int ShaftLenght{ get; }

        public Arrow()
        {

        }
        public Arrow(ArrowHead arrowHead, Fletchling fletchling, int shaftLenght)
        {
            ArrowHead = arrowHead;
            Fletchling = fletchling;
            ShaftLenght = shaftLenght;
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
