using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreEnumExercises.Exercise1
{
    class StovePlate
    {
        public HeatLevel Hotness { get; private set; }

        public StovePlate()
        {
            Hotness = HeatLevel.None;
        }

        public void IncreaseHeat()
        {
            if (Hotness == HeatLevel.None)
            {
                Hotness = HeatLevel.Low;
            }
            else if (Hotness == HeatLevel.Low)
            {
                Hotness = HeatLevel.High;
            }
            else
            {
                Console.WriteLine("At max heat");
            }
        }

        public void DecreaseHeat()
        {
            /* Vi använder en switch här för att ge er en chans att öva
             * både på if- och switch-syntax. I normala fall hade vi
             * förmodligen använt samma lösning för increase och decrease.
             */
            switch (Hotness)
            {
                case HeatLevel.High:
                    Hotness = HeatLevel.Low;
                    break;
                case HeatLevel.Low:
                    Hotness = HeatLevel.None;
                    break;
                default:
                    Console.WriteLine("Heat already off");
                    break;
            }
        }
    }
}
